namespace Bank.Domain
{
    /// <summary>
    /// Representa una cuenta bancaria con operaciones de débito y crédito.
    /// Autor: Diego Castillo
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        
        /// <summary>
        /// Constructor privado para prevenir instanciación sin parámetros.
        /// </summary>
        private BankAccount() { }
        
        /// <summary>
        /// Inicializa una nueva instancia de la clase BankAccount con el nombre del cliente y el saldo inicial.
        /// </summary>
        /// <param name="customerName">Nombre del cliente titular de la cuenta.</param>
        /// <param name="balance">Saldo inicial de la cuenta.</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        
        /// <summary>
        /// Obtiene el nombre del cliente titular de la cuenta.
        /// </summary>
        public string CustomerName { get { return m_customerName; } }
        
        /// <summary>
        /// Obtiene el saldo actual de la cuenta.
        /// </summary>
        public double Balance { get { return m_balance; }  }
        
        /// <summary>
        /// Realiza un débito en la cuenta bancaria.
        /// </summary>
        /// <param name="amount">Cantidad a debitar. Debe ser mayor que cero y menor o igual al saldo disponible.</param>
        /// <exception cref="ArgumentOutOfRangeException">Se lanza cuando el monto es mayor al saldo disponible o es negativo.</exception>
        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException("amount");
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance -= amount;
        }
        
        /// <summary>
        /// Realiza un crédito (depósito) en la cuenta bancaria.
        /// </summary>
        /// <param name="amount">Cantidad a acreditar. Debe ser mayor que cero.</param>
        /// <exception cref="ArgumentOutOfRangeException">Se lanza cuando el monto es negativo.</exception>
        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance += amount;
        }
    }
}

