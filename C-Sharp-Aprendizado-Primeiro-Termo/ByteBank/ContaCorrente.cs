namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular {get;set;}
        private int _Agencia;
        private int _Numero {get;set;}
        private double _Saldo;

        public double Saldo
        {
            get{return _Saldo;}
        }

        public int Agencia
        {
            get{return _Agencia;}
            set{_Agencia = value;}
        }
        public int Numero
        {
            get{return _Numero;}
            set{_Numero = value;}
        }
        


        public ContaCorrente(int _Agencia,int _Numero,Cliente Titular){
            this._Agencia = _Agencia;
            this._Numero = _Numero;
            this.Titular = Titular;
            this._Saldo = 0.0;
        }

        public bool Deposito(double valor){
            if(valor >= 0){
                this._Saldo += valor;
                return true;
            } else{
                return false;
            }
        }
        public bool Saque(double valor){
            if(valor >= 0){
                if(this._Saldo >= valor){
                    this._Saldo -= valor;
                    return true;
                } else{
                    return false;
                }
            }else
            return false;
        }
        public bool Transferencia(ContaCorrente destino, double valor){
            if (this.Saque(valor)){
                destino.Deposito(valor);
                return true;
            } else {
                return false;
            }
        }
    }
}