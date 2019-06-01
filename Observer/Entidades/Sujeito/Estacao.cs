using System.Collections.Generic;

namespace Observer.Entidades.Sujeito
{
    public class Estacao : IObservable
    {
        private IList<IObserver> observers = new List<IObserver>();

        private double temperatura;
        public double Temperatura
        {
            get { return temperatura; }
            set
            {
                temperatura = value;
                Notify();
            }
        }

        private double pressao;
        public double Pressao
        {
            get { return pressao; }
            set
            {
                pressao = value;
                Notify();
            }
        }

        private double umidade;
        public double Umidade
        {
            get { return umidade; }
            set
            {
                umidade = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public override string ToString()
        {
            return $"Temperatura: {Temperatura}\nPressão: {Pressao}\nUmidade: {Umidade}";
        }
    }
}
