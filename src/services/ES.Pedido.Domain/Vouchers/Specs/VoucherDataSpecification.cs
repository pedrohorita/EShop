using ES.Pedido.Domain.Vouchers;
using NetDevPack.Specification;
using System;
using System.Linq.Expressions;

namespace ES.Pedidos.Domain.Vouchers.Specs
{
    public class VoucherDataSpecification : Specification<Voucher>
    {
        public override Expression<Func<Voucher, bool>> ToExpression()
        {
            return voucher => voucher.DataValidade >= DateTime.Now;
        }
    }
}
