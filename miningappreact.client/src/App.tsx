import { /*useEffect,*/ MouseEventHandler, useState } from 'react';
import './App.css';
import MineGenerator from './MineGenerator';

//interface Forecast {
//    date: string;
//    temperatureC: number;
//    temperatureF: number;
//    summary: string;
//}

function Square({ value, onSquareClick }: { value: string, onSquareClick: MouseEventHandler }) {
    return <button className="square" onClick={onSquareClick}>{value}</button>
}

function Board() {
    const [squares, setSquares] = useState(Array(9).fill(null));

    function handleClick(i: number) {
        const nextSquares = squares.slice();
        nextSquares[i] = "X";
        setSquares(nextSquares);
    }

    const rows = [];
    for (let i = 0; i < 3; i++) {
        const squareElements = [];
        for (let j = 0; j < 3; j++) {
            const totalIndex = i * 3 + j;
            squareElements.push(<Square value={squares[totalIndex]} onSquareClick={() => handleClick(totalIndex)} />);
        }
        rows.push(<div className="board-row">{squareElements}</div>);
    }


    return (rows);
}

function App() {
    return (<MineGenerator />);
    //const [forecasts, setForecasts] = useState<Forecast[]>();
    //
    //useEffect(() => {
    //    populateWeatherData();
    //}, []);
    //
    //const contents = forecasts === undefined
    //    ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
    //    : <table className="table table-striped" aria-labelledby="tableLabel">
    //        <thead>
    //            <tr>
    //                <th>Date</th>
    //                <th>Temp. (C)</th>
    //                <th>Temp. (F)</th>
    //                <th>Summary</th>
    //            </tr>
    //        </thead>
    //        <tbody>
    //            {forecasts.map(forecast =>
    //                <tr key={forecast.date}>
    //                    <td>{forecast.date}</td>
    //                    <td>{forecast.temperatureC}</td>
    //                    <td>{forecast.temperatureF}</td>
    //                    <td>{forecast.summary}</td>
    //                </tr>
    //            )}
    //        </tbody>
    //    </table>;
    //
    //return (
    //    <div>
    //        <h1 id="tableLabel">Weather forecast</h1>
    //        <p>This component demonstrates fetching data from the server.</p>
    //        {contents}
    //    </div>
    //);
    //
    //async function populateWeatherData() {
    //    const response = await fetch('weatherforecast');
    //    const data = await response.json();
    //    setForecasts(data);
    //}
}

export default App;