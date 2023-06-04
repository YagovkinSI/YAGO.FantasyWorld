import * as React from 'react';
import { connect } from 'react-redux';
import { Link, useParams } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as WeatherForecastsStore from '../store/WeatherForecasts';

type WeatherForecastProps =
  WeatherForecastsStore.WeatherForecastsState
  & typeof WeatherForecastsStore.actionCreators;

const FetchData: React.FC<WeatherForecastProps> = (props) => {
  const { startDateIndex } = useParams();
  const startDateIndexNumber = startDateIndex == undefined
    ? 0
    : parseInt(startDateIndex, 10) || 0;

  React.useEffect(() => {
    props.requestWeatherForecasts(startDateIndexNumber);
  });

  const renderForecastsTable = () => {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th style={{ width: '30%' }}>Дата</th>
            <th style={{ width: '30%' }}>Температура</th>
            <th style={{ width: '40%' }}>Погода</th>
          </tr>
        </thead>
        <tbody>
          {props.forecasts.map((forecast: WeatherForecastsStore.WeatherForecast) =>
            <tr key={forecast.date}>
              <td>{new Date(Date.parse(forecast.date)).toLocaleDateString('ru-ru')}</td>
              <td>{forecast.temperatureC}°C</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  const renderPagination = () => {
    const prevStartDateIndex = (props.startDateIndex || 0) - 5;
    const nextStartDateIndex = (props.startDateIndex || 0) + 5;
    return (
      <div className="d-flex justify-content-between">
        <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-data/${prevStartDateIndex}`}>Назад</Link>
        {props.isLoading && <span>Загрузка...</span>}
        <Link className='btn btn-outline-secondary btn-sm' to={`/fetch-data/${nextStartDateIndex}`}>Вперёд</Link>
      </div>
    );
  }

  return (
    <React.Fragment>
      <h1 id="tabelLabel">Прогноз погоды</h1>
      <p>Этот компонент демонстрирует получение данных с сервера и работу с параметрами URL.</p>
      {renderForecastsTable()}
      {renderPagination()}
    </React.Fragment>
  );
}

export default connect(
  (state: ApplicationState) => state.weatherForecasts,
  WeatherForecastsStore.actionCreators
)(FetchData as any);
