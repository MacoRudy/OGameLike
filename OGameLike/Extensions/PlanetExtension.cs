using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OGameLike.Extensions
{
    public enum EnumResource
    {
        ENERGIE = 1,
        OXYGENE = 2,
        ACIER = 3,
        URANIUM = 4
    }

    public static class PlanetExtension
    {
        public static string getEnum(EnumResource enumResource)
        {
            string ressource;
            switch (enumResource)
            {
                case EnumResource.ENERGIE:
                    ressource = "Energie";
                    break;
                case EnumResource.OXYGENE:
                    ressource = "Oxygène";
                    break;
                case EnumResource.ACIER:
                    ressource = "Acier";
                    break;
                case EnumResource.URANIUM:
                    ressource = "Uranium";
                    break;
                default:
                    ressource = "";
                    break;
            }
            return ressource;
        }
    }
}