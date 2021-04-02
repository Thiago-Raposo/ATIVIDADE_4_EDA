namespace arvorebin 
{
	class No
	{
		public No noEsquerdo;
		public int info;
		public No noDireito;
        public int fatorBalanceamento;

		public No(int info)
		{
			this.noEsquerdo = null;
			this.info = info;
			this.noDireito = null;
            this.fatorBalanceamento=0;
		}
	}
}