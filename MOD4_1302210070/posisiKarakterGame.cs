using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD4_1302210070
{
    public class posisiKarakterGame
    {
        public enum pState { Tengkurap, Jongkok, Berdiri, Terbang};
        public enum Tombol { TombolS, TombolW, TombolX};

        class transition
        {
            public pState prevState;
            public pState nextState;
            public Tombol tombol;

            public transition(pState prevState, pState nextState, Tombol tombol)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.tombol = tombol;
            }
        }

        transition[] transitions =
        {
            new transition(pState.Tengkurap, pState.Jongkok, Tombol.TombolW),
            new transition(pState.Jongkok, pState.Tengkurap, Tombol.TombolS),
            new transition(pState.Jongkok, pState.Berdiri, Tombol.TombolW),
            new transition(pState.Berdiri, pState.Jongkok, Tombol.TombolS),
            new transition(pState.Berdiri, pState.Terbang, Tombol.TombolW),
            new transition(pState.Terbang, pState.Berdiri, Tombol.TombolS),
            new transition(pState.Terbang, pState.Jongkok, Tombol.TombolX),
      
        };

        public pState currentState;

        public pState getNextState(pState prevState, Tombol tombol)
        {
            pState nextState = prevState;

            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].tombol == tombol)
                {
                    nextState = transitions[i].nextState;
                }
            }
            return nextState;
        }

        public void tombolAktif(Tombol tombol)
        {
            pState nextState = getNextState(currentState, tombol);
            currentState = nextState;

            Console.WriteLine($"tombol yg ditekan: {tombol}, current state: {currentState}");
            Console.WriteLine();

            if (currentState == pState.Berdiri)
            {
                Console.Write("posisi Standby"); 
            }
            if(currentState== pState.Tengkurap)
            {
                Console.Write("posisi istirahat");
            }
        }

    }
}
