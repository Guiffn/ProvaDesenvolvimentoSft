using System;

namespace Aluno2.Models;

public class Folha
{

    public int FolhaId { get; set; }
    public double Valor { get; set; }
    public int Quantidade { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public double SalarioBruto { get; set; }
    public double ImpostoIrrf { get; set; }
    public double ImpostoInss { get; set; }
    public double ImpostoFgts { get; set; }
    public double SalarioLiquido { get; set; }
    public Funcionario FuncionarioFolha { get; set; }


}
