import * as WeatherForecasts from './WeatherForecasts';
import * as Counter from './Counter';

export interface ApplicationState {
    counter: Counter.CounterState | undefined;
    weatherForecasts: WeatherForecasts.WeatherForecastsState | undefined;
}

export const reducers = {
    counter: Counter.reducer,
    weatherForecasts: WeatherForecasts.reducer
};

export interface AppThunkAction<TAction> {
    (dispatch: (action: TAction) => void, getState: () => ApplicationState): void;
}
