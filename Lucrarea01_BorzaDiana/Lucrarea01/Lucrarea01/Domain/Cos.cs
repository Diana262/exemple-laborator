using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucrarea01.Domain
{
    [AsChoice]
    public static partial class Cos
    {
        public interface ICos
        {
            // void Match(Func<object, object> whenUnvalidatedCos, Func<object, object> whenGolCos, Func<object, object> whenInvalidatedCos, Func<object, ICos> whenValidatedCos, Func<object, object> whenCosPlatit);
        }

        public record UnvalidatedCos(IReadOnlyCollection<UnvalidatedProduse> ProduseList, CosDetails CosDetails) : ICos;

        public record InvalidatedCos(IReadOnlyCollection<UnvalidatedProduse> ProduseList, string reason) : ICos;

        public record GolCos(IReadOnlyCollection<UnvalidatedProduse> ProduseList, string reason) : ICos;
        
        public record ValidatedCos(IReadOnlyCollection<ValidatedProduse> ProduseList, CosDetails CosDetails) : ICos;

        public record CosPlatit(IReadOnlyCollection<ValidatedProduse> ProduseList, CosDetails CosDetails, DateTime PublishedDate) : ICos;

    }
}
