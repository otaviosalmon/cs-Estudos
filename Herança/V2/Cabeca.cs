using System;


namespace Herança.V2
{
    public class Cabeca
    {
        private string _message;
        private int _repeatTimes;

        public Cabeca(string message, int times)
        {
            _message = message;
            _repeatTimes = times;
        }

        public void Talk()
        {
            for (int i = 0; i < _repeatTimes; i++)
            {
                Console.WriteLine(_message);
            }
        }
    }
}
