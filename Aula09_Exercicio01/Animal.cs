using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace é um "pacote" que organiza o código dentro do projeto
namespace Aula09_Exercicio01
{
    // A classe 'Animal' é marcada como 'internal':
    // Isso significa que ela só pode ser acessada de dentro do mesmo projeto.
    // É uma forma de proteger o código e impedir que outras partes do sistema tenham acesso direto,
    // a menos que estejam no mesmo projeto.
    internal class Animal
    {
        // 'public' indica que esse método pode ser acessado de qualquer lugar que tenha acesso à classe.

        // 'virtual' permite que esse método seja sobrescrito por classes que herdem de 'Animal'.
        // Isso faz parte do conceito de polimorfismo na programação orientada a objeto.

        // 'void' indica que o método não retorna nenhum valor.
        public virtual void emitirSom()
        {
            // Escreve no console uma mensagem genérica, que pode ser substituída por subclasses.
            Console.WriteLine("Som do animal");
        }
    }
}
