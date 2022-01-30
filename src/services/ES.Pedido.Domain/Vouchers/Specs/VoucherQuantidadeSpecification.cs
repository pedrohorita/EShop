using ES.Pedido.Domain.Vouchers;
using NetDevPack.Specification;
using System;
using System.Linq.Expressions;

namespace ES.Pedidos.Domain.Vouchers.Specs
{
    public class VoucherQuantidadeSpecification : Specification<Voucher>
    {
        public override Expression<Func<Voucher, bool>> ToExpression()
        {
            return voucher => voucher.Quantidade > 0;
        }
    }
}
