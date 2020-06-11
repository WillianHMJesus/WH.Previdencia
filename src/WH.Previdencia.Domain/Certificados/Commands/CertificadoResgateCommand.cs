﻿using MediatR;
using System;

namespace WH.Previdencia.Domain.Certificados.Commands
{
    public class CertificadoResgateCommand : IRequest<Certificado>
    {
        public string NumeroCertificado { get; set; }
        public decimal Valor { get; set; }
    }
}
