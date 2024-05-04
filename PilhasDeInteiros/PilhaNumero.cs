namespace PilhasDeInteiros
{
    internal class PilhaNumero
    {
        Numero? topo;
        int qtdNumeros;
        int maiorValor;
        int menorValor;
        int media;

        internal int QtdNumeros { get => qtdNumeros; set => qtdNumeros = value; }
        internal int MaiorValor { get => maiorValor; set => maiorValor = value; }
        internal int MenorValor { get => menorValor; set => menorValor = value; }
        public int Media { get => media; set => media = value; }

        public PilhaNumero()
        {
            this.topo = null;
            this.QtdNumeros = 0;
        }

        public void Push(Numero n)
        {
            Numero? aux = this.topo;
            this.topo = n;
            n.SetAnterior(aux);
            this.QtdNumeros++;

            this.RunOver(false);
        }

        public void pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine($"O número {this.topo.GetN()} foi retirado da pilha.");
                this.QtdNumeros--;
                this.topo = this.topo.GetAnterior();

                this.RunOver(false);
            }
            else
            {
                Console.WriteLine($"Pilha vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        bool IsEmpty()
        {
            if (this.topo == null) return true;
            else return false;
        }

        public void RunOver(bool print) //reorganiza propiedades de maior, menor numero e media
        {
            Numero? aux = this.topo;
            int index = this.QtdNumeros;
            if (aux == null)
            {
                Console.WriteLine("Pilha vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                int soma = 0;
                do
                {
                    if (this.QtdNumeros == 1)
                    {
                        this.MaiorValor = aux.GetN();
                        this.MenorValor = aux.GetN();
                    }
                    else
                    {
                        if (aux.GetN() > this.MaiorValor) this.MaiorValor = aux.GetN();
                        if (aux.GetN() < this.MenorValor) this.MenorValor = aux.GetN();
                    }

                    soma += aux.GetN();

                    //o booleano print serve para identificar se o metodo RunOver será utilizado para imprimir a pilha
                    if (print) Console.WriteLine($"Posição: {index} - Numero: {aux.GetN()}");

                    aux = aux.GetAnterior();
                    index--;
                } while (aux != null);
                this.Media = soma / this.QtdNumeros;
            }
        }

        public void GetImPar(string mensagem, bool par)
        {
            Numero? aux = this.topo;
            int contador = 0;
            Console.WriteLine(mensagem);
            if (IsEmpty())
            {
                Console.WriteLine("Pilha vazia. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    if (aux.GetN() % 2 != 0 && !par)
                    {
                        contador++;
                        Console.WriteLine($"Elemento: {contador} - Numero: {aux.GetN()} ");
                    }

                    if (aux.GetN() % 2 == 0 && par)
                    {
                        contador++;
                        Console.WriteLine($"Elemento: {contador} - Numero: {aux.GetN()}");
                    }
                    aux = aux.GetAnterior();
                } while (aux != null);
            }
        }
    }
}