using LojaCaelum.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCaelum
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateHelper.GeraSchema();

            Console.Read();
        }
    }
}
