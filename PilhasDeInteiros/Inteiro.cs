namespace PilhasDeInteiros
{
    internal class Numero
    {
        int N;
        Numero Anterior;

        public Numero(int n)
        {
            this.N = n;
            this.Anterior = null;
        }

        public void SetAnterior(Numero num) { this.Anterior = num; }
        public Numero GetAnterior() { return this.Anterior; }
        public int GetN() { return this.N; }
        public string PrintN() { return $"Numero: {this.N}"; }
    }
}
