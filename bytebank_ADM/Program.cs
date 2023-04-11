using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;


#region

//Funcionario pedro = new Funcionario("32165498701", 2000);
//pedro.Nome = "Pedro Pedrone";

//Console.WriteLine("Nome: " + pedro.Nome);
//Console.WriteLine("Bonificacao " + pedro.GetBonificacao());
////Console.WriteLine("A Premiaçao Semetral é " + pedro.GetPremiacaoSemestral());

//Diretor roberta = new Diretor("1234567890x");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine("Nome: " + roberta.Nome);
//Console.WriteLine("Bonificação: " + roberta.GetBonificacao());
////.WriteLine("Premiacao Semetral  é " + roberta.GetPremiacaoSemestral());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDefuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();
//Console.WriteLine("Novo Salario do Pedro" + pedro.Salario);
//Console.WriteLine("Novo Salario da Roberta " + roberta.Salario);


//Console.WriteLine();
//Console.WriteLine("Pressione enter para Sair ");
//Console.ReadLine();

#endregion


//calcularBonificacao();
usarSistema();

void calcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    Designer ulisses = new Designer("32165498701");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new("21345678901");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new("12345678901");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new("43215678901");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(igor);

    Console.WriteLine("Total de Bonificacao = " + gerenciador.TotalDeBonificacao);

        
}


void usarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new("22321654987");
    ingrid.Nome = "Igrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new("11321654987");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "456";

    ParceiroComercial caio = new();
    caio.Senha = "4564";
    

    sistema.Logar(ingrid, "1234");
    sistema.Logar(ursula, "456");
    sistema.Logar(caio, "4564");

}