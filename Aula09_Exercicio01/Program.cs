using System;
using System.Collections.Generic;
// Importa as classes definidas no mesmo namespace do projeto
using Aula09_Exercicio01;

namespace Aula09_Exercicio01
{
    // 'Program' é a classe principal que contém o ponto de entrada do programa
    class Program
    {
        // 'static' indica que o método pertence à classe e não a uma instância.
        // 'void' significa que o método não retorna nada.
        // 'Main' é o ponto de entrada da aplicação — onde tudo começa a rodar.
        // 'string[] args' permite receber argumentos de linha de comando, se necessário.
        static void Main(string[] args)
        {
            // Aqui estamos usando **polimorfismo**: criamos variáveis do tipo 'Animal',
            // mas instanciamos objetos de classes derivadas (Cachorro, Gato, etc.)
            Animal cachorro = new Cachorro();
            Animal gato = new Gato();
            Animal peixe = new Peixe();
            Animal passaro = new Passaro();

            // 'List<Animal>' é uma lista genérica (do namespace System.Collections.Generic)
            // que armazena objetos do tipo Animal (e seus derivados).
            List<Animal> animais = new List<Animal> { cachorro, gato, peixe, passaro };

            // 'foreach' é uma estrutura de repetição usada para percorrer a lista
            // Cada elemento da lista é chamado de 'animal' a cada iteração
            foreach (Animal animal in animais)
            {
                // Chamada polimórfica: o método 'emitirSom' que será executado
                // depende do tipo real do objeto (Cachorro, Gato, etc.)
                animal.emitirSom();
            }
        }
    }
}
