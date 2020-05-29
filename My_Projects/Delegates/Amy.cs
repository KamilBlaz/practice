using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Amy
    {

        public GetSecretIngredient MySecretIngredientMethod
        {
            get{
                return new GetSecretIngredient(AmysSecretIngredient);

            }
        }

        private string AmysSecretIngredient(int amount)
        {
            if (amount < 10)
                return amount.ToString() + " puszek sardynek -- potrzebujesz wiecej!";
            else
                return amount.ToString() + " puszek sarydnek";
        }
    }
}
