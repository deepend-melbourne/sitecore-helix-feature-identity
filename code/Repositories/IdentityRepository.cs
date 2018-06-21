using System;
using Sitecore.Data.Items;
using Sitecore.Feature.Identity.Models;
using Sitecore.Foundation.Models.Services;
using Sitecore.Foundation.SitecoreExtensions.Extensions;

namespace Sitecore.Feature.Identity.Repositories
{
    public static class IdentityRepository
    {
        public static IIdentity Get([NotNull] Item contextItem)
        {
            if (contextItem == null)
                throw new ArgumentNullException(nameof(contextItem));

            var item = contextItem.GetAncestorOrSelfOfTemplate(Templates.Identity.ID) ?? Context.Site.GetContextItem(Templates.Identity.ID);

            return item.As<IIdentity>();
        }
    }
}
