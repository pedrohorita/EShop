using NetDevPack.Specification;
using System;
using System.Linq.Expressions;

namespace ES.Pedidos.Domain.Vouchers.Specs
{
    public class VoucherAtivoSpecification : Specification<Voucher>
    {
        public override Expression<Func<Voucher, bool>> ToExpression()
        {
            return voucher => voucher.Ativo && !voucher.Utilizado;
        }
    }
}
