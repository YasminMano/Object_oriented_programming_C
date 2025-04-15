using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio01
{
    // 'Cachorro' está herdando de 'Animal' com o uso de ': Animal'
    // Isso significa que a classe 'Cachorro' é uma subclasse e pode usar/reescrever os métodos da classe 'Animal'.
    internal class Cachorro : Animal
    {
        // 'override' é usado para sobrescrever um método que foi marcado como 'virtual' na classe base (Animal).
        // Isso permite alterar o comportamento original do método.
        public override void emitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }
}
