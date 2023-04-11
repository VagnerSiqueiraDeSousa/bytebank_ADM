using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDefuncionarios { get; private set; }

        public abstract double GetBonificacao();
     

        //public virtual double GetPremiacaoSemestral // remover
        //public abstract double GetPremiacaoSemetral(); // estramos transformando em uma classe abstrata temos que remover o bloco a baixo tambem, no  caso as classe filhas ou a classe herdeira sera responsavel de realizar a implentação dos objetos
        //{
        //    return this.Salario * 0.20;// remover; ficarar comentando para revisao
        //}

        public Funcionario(string cpf, double Salario)
        {
            this.Salario = Salario;
            this.Cpf = cpf;
            TotalDefuncionarios++;
            //Console.WriteLine("Criando um funcionário.");
        }

        public abstract void AumentarSalario();

      

    }
}
