import * as React from 'react';
import { connect } from 'react-redux';
import { ApplicationState } from '../store';
import * as CounterStore from '../store/Counter';

type CounterProps =
    CounterStore.CounterState &
    typeof CounterStore.actionCreators;

const Counter: React.FC<CounterProps> = (props) => {
    return (
        <React.Fragment>
            <h1>Счетчик</h1>
            <p>Это простой пример компонента React.</p>
            <p aria-live="polite">Текущее значение: <strong>{props.count}</strong></p>
            <button type="button"
                className="btn btn-primary btn-lg"
                onClick={() => { props.increment(); }}>
                Увеличить
            </button>
        </React.Fragment>
    );
};

export default connect(
    (state: ApplicationState) => state.counter,
    CounterStore.actionCreators
)(Counter);
