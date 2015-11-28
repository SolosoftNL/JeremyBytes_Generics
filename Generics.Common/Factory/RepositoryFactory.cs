using System;
using System.Configuration;
using Generics.Common.Interface;

namespace Generics.Common.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetPersonRepository()
        {
            string configString =
                ConfigurationManager.AppSettings["IPersonRepository"];
            Type resolvedType = Type.GetType(configString);
            object obj = Activator.CreateInstance(resolvedType);
            IPersonRepository rep = obj as IPersonRepository;
            return rep;
        }

        public static IProductRepository GetProductRepository()
        {
            string configString =
                ConfigurationManager.AppSettings["IProductRepository"];
            Type resolvedType = Type.GetType(configString);
            object obj = Activator.CreateInstance(resolvedType);
            IProductRepository rep = obj as IProductRepository;
            return rep;
        }
    }
}
