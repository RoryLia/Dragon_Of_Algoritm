using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Of_Algoritm.Source.Core
{
    public class GameManager
    {
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            {
                //Lazy initialization
                if (_instance == null)
                {
                    _instance = new GameManager();
                }
                return _instance;
            }
        }
    }

    //Ninguém de fora pode instanciar!
    private GameManager() { }

    //Dados compartilhados
    public int Score { get; set; }
    public int TotalEnemiesKilled { get; set; }

    public GameState CurrentState { get; set; }
}
