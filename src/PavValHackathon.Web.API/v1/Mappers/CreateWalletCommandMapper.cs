using PavValHackathon.Web.API.v1.Commands.Wallets;
using PavValHackathon.Web.API.v1.Contracts.Requests;
using PavValHackathon.Web.Common;
using PavValHackathon.Web.Common.Mapping;

namespace PavValHackathon.Web.API.v1.Mappers
{
    public class CreateWalletCommandMapper : IMapperDefinition<CreateWalletRequestDocument, CreateWalletCommand>
    {
        public CreateWalletCommand Map(CreateWalletRequestDocument document)
        {
            Assert.IsNotNull(document, nameof(document));

            return Map(new CreateWalletCommand(), document);
        }

        public CreateWalletCommand Map(CreateWalletCommand command, CreateWalletRequestDocument document)
        {
            Assert.IsNotNull(command, nameof(command));
            Assert.IsNotNull(document, nameof(document));

            command.Title = document.Title;
            command.CurrencyId = document.CurrencyId;
            
            return command;
        }
    }
}