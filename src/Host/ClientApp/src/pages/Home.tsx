import * as React from 'react';

const Home: React.FC = () => {
  const render = () => {
    return (
      <div style={{textAlign: 'center'}}>
        <h1>YAGO: Fantasy World</h1>
        <p>Добро пожаловать!</p>
        <p>Возьми под своё управление небольшое владение и вступи в борьбу за власть.</p>
        <p>Торгуй и заключай союзы с единомышленниками, совершай молниеносные набеги на своих врагов.</p>
        <p>Построй самое могущественное государство, в котором ты – истинный правитель!</p>
      </div>
    )
  }

  return render();
};

export default Home;
