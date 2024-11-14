import { useState, useEffect } from 'react';
import './App.css';

function Selector({ value, options, selectCallback }: { value: string, options: string[], selectCallback: (value: string) => void }) {
    return (
        <div>
            <label htmlFor="select">Select: </label>
            <select name="select" value={value} onChange={e => selectCallback(e.target.value)}>
                <option value='' key="empty" disabled></option>
                {options.map(option => <option value={option} key={option}>{option}</option>)}
            </select>
        </div>
    );
}

function MineGenerator() {
    const [environments, setEnvironments] = useState(Array<string>());
    const [selectedEnvironment, setSelectedEnvironment] = useState('');
    const [mineProductTypes, setMineProductTypes] = useState(Array<string>());
    const [selectedMineProductType, setSelectedMineProductType] = useState('');
    const [mineProducts, setMineProducts] = useState(Array<string>());
    const [selectedMineProduct, setSelectedMineProduct] = useState('');
    const [byproducts, setByproducts] = useState(Array<string>());
    const [selectedByproducts, setSelectedByproducts] = useState(Array<string>(2));

    useEffect(() => {
        fetch('https://localhost:7059/api/MineGeneration/Environments')
            .then(response => response.json())
            .then(data => setEnvironments(data));
    });

    async function setDependentOptions(url: string, setState: React.Dispatch<React.SetStateAction<string[]>> ) {
        const response = await fetch(url);
        const options = await response.json();
        setState(options);
    }

    async function resetDependentSelections(... setStates: React.Dispatch<React.SetStateAction<string>>[]) {
        setStates.forEach(setState => setState(''));
    }

    return (
        <>
            <p>Mine generator!</p>
            <Selector
                value={selectedEnvironment}
                options={environments}
                selectCallback={
                    environment => {
                        setSelectedEnvironment(environment);
                        setDependentOptions(`https://localhost:7059/api/MineGeneration/${environment}/MineProductTypes`, setMineProductTypes);
                        resetDependentSelections(setSelectedMineProductType, setSelectedMineProduct);
                    }
                }
            />
            <p>Selected environment: {selectedEnvironment}</p>
            {
                selectedEnvironment &&
                <Selector
                    value={selectedMineProductType}
                    options={mineProductTypes}
                    selectCallback={
                        mineProductType => {
                            setSelectedMineProductType(mineProductType);
                            setDependentOptions(`https://localhost:7059/api/MineGeneration/${selectedEnvironment}/${mineProductType}/MineProducts`, setMineProducts);
                            resetDependentSelections(setSelectedMineProduct);
                        }
                    }
                />    
            }
            <p>Selected mine product type: {selectedMineProductType}</p>
            {
                selectedMineProductType &&
                <Selector
                    value={selectedMineProduct}
                    options={mineProducts}
                    selectCallback={
                        mineProduct => {
                            setSelectedMineProduct(mineProduct);
                        }
                    }
                />    
            }
            <p>Selected mine product: {selectedMineProduct}</p>
            {
                selectedMineProduct &&
                <Selector
                    value={selectedByproducts[0]}
                    options={byproducts}
                    selectCallback={
                        byproduct => {
                            const oldByproducts = byproducts.slice();
                            oldByproducts[0] = byproduct;
                            setByproducts(oldByproducts);
                        }
                    }
                />
            }
        </>
    );
}

export default MineGenerator;