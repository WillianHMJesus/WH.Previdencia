using System;

namespace WH.Previdencia.Domain.Certificados.Validations
{
    public class CustomValidator
    {
        public static bool DataIgualADataDeHoje(DateTime data)
        {
            return data == DateTime.Now;
        }

        public static bool DataMenorIgualQueADataDeHoje(DateTime data)
        {
            return data <= DateTime.Now;
        }

        public static bool DataMaiorIgualQueADataDeHoje(DateTime data)
        {
            return data >= DateTime.Now;
        }

        public static bool ValorMaiorQueZero(decimal valor)
        {
            return valor > 0;
        }

        
    }
}
