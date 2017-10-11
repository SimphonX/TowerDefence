using Enemys.Units;
using Enemys.Units.Behavior;
using Enemys.Wave;
using System;
using System.Collections.Generic;

namespace Enemys
{
	public class UnitDeployment
    {

        private Deploy wave;

        private List<Unit> unit = new List<Unit>();
        
        public List<Unit> Unit { get => unit; set => unit = value; }
        public Deploy Wave { get => wave; set => wave = value; }
        private void CreateBossUnit(Unit s, IUnitBehaviour k)
        {
            s.Behaviour = k;
            unit.Add(s);
        }
        public void Start(int level)
        {
            string eil = Wave.CreateWave(level);
            int sk = -1;
            System.Console.Write(eil+ "\n");
            while (eil.Length/2 > ++sk)
                for(int i = 0; i < (int)Char.GetNumericValue(eil[sk*2]); i++)
                {
                    System.Console.Write(eil[sk * 2]);
                    switch (eil[sk * 2 + 1])
                    {
                        case 'B':
                            CreateBossUnit(new Boss(level), new AttackUnit());
                            break;
                        case 'G':
                            CreateBossUnit(new GoldUnit(level), new Natural());
                            break;
                        case 'N':
                            CreateBossUnit(new NormalUnit(level), new AttackUnit());
                            break;
                        case 'S':
                            CreateBossUnit(new SpeedUnit(level), new Rush());
                            break;
                        case 'T':
                            CreateBossUnit(new TankUnit(level), new Defence());
                            break;
                    }
                }
                    
        }
        public void Attack()
        {
            foreach (Unit s in unit)
            {
                s.Attack();
                s.Move();
            }
        }

    }
}
