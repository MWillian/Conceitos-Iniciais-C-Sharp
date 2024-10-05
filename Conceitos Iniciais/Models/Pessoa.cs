using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Iniciais.Models // o namespace vai organizar as classes. Representa um caminho lógico para representar classes no mesmo escopo
{
    //Inicialização da classe Pessoa.    
    public class Pessoa 
    {
        /*Propriedades/atributos da class. Representa as características que a classe possui*/
        public string Nome { get; set; } //o get faz a captura do valor, e o set faz a sua atribuição.
        public int Idade { get; set; }

        // Declaração do método Apresentar. Retorna uma saída no console com as propriedades Nome e Idade.
        public void Apresentar(string @class){
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos."); /*Template String no C# */
        }
    }
}
