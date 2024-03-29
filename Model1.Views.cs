//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(Bibliothèque.BibliothèqueEntities),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets6007c1d1133dfcdbdb706af4369d0e04263ed65a2894a725717dc9ed11b4dc75))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework 6 Power Tools", "0.9.5.0")]
    internal sealed class ViewsForBaseEntitySets6007c1d1133dfcdbdb706af4369d0e04263ed65a2894a725717dc9ed11b4dc75 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "6007c1d1133dfcdbdb706af4369d0e04263ed65a2894a725717dc9ed11b4dc75"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "BibliothèqueModelStoreContainer.Emprinte")
            {
                return GetView0();
            }

            if (extentName == "BibliothèqueModelStoreContainer.Filiere")
            {
                return GetView1();
            }

            if (extentName == "BibliothèqueModelStoreContainer.Groupe")
            {
                return GetView2();
            }

            if (extentName == "BibliothèqueModelStoreContainer.Livre")
            {
                return GetView3();
            }

            if (extentName == "BibliothèqueModelStoreContainer.Ouvrage")
            {
                return GetView4();
            }

            if (extentName == "BibliothèqueModelStoreContainer.Secteur")
            {
                return GetView5();
            }

            if (extentName == "BibliothèqueModelStoreContainer.Stagiaire")
            {
                return GetView6();
            }

            if (extentName == "BibliothèqueModelStoreContainer.Theme")
            {
                return GetView7();
            }

            if (extentName == "BibliothèqueModelStoreContainer.LivrePerdu")
            {
                return GetView8();
            }

            if (extentName == "BibliothèqueEntities.Emprinte")
            {
                return GetView9();
            }

            if (extentName == "BibliothèqueEntities.Filiere")
            {
                return GetView10();
            }

            if (extentName == "BibliothèqueEntities.Groupe")
            {
                return GetView11();
            }

            if (extentName == "BibliothèqueEntities.Livre")
            {
                return GetView12();
            }

            if (extentName == "BibliothèqueEntities.Ouvrage")
            {
                return GetView13();
            }

            if (extentName == "BibliothèqueEntities.Secteur")
            {
                return GetView14();
            }

            if (extentName == "BibliothèqueEntities.Stagiaire")
            {
                return GetView15();
            }

            if (extentName == "BibliothèqueEntities.Theme")
            {
                return GetView16();
            }

            if (extentName == "BibliothèqueEntities.LivrePerdus")
            {
                return GetView17();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Emprinte.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Emprinte
        [BibliothèqueModel.Store.Emprinte](T1.Emprinte_IdEmprinte, T1.Emprinte_IdSagiaire, T1.Emprinte_IdLivre, T1.Emprinte_DateEmprinte, T1.Emprinte_DateRoteur)
    FROM (
        SELECT 
            T.IdEmprinte AS Emprinte_IdEmprinte, 
            T.IdSagiaire AS Emprinte_IdSagiaire, 
            T.IdLivre AS Emprinte_IdLivre, 
            T.DateEmprinte AS Emprinte_DateEmprinte, 
            T.DateRoteur AS Emprinte_DateRoteur, 
            True AS _from0
        FROM [BibliothèqueEntities].Emprinte AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Filiere.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Filiere
        [BibliothèqueModel.Store.Filiere](T1.Filiere_IdFiliere, T1.Filiere_NomFiliere, T1.Filiere_IdSecteur)
    FROM (
        SELECT 
            T.IdFiliere AS Filiere_IdFiliere, 
            T.NomFiliere AS Filiere_NomFiliere, 
            T.IdSecteur AS Filiere_IdSecteur, 
            True AS _from0
        FROM [BibliothèqueEntities].Filiere AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Groupe.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Groupe
        [BibliothèqueModel.Store.Groupe](T1.Groupe_IdGroupe, T1.Groupe_NomGroupe, T1.Groupe_IdFiliere)
    FROM (
        SELECT 
            T.IdGroupe AS Groupe_IdGroupe, 
            T.NomGroupe AS Groupe_NomGroupe, 
            T.IdFiliere AS Groupe_IdFiliere, 
            True AS _from0
        FROM [BibliothèqueEntities].Groupe AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Livre.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Livre
        [BibliothèqueModel.Store.Livre](T1.Livre_IdLivre, T1.Livre_IdOuvrage, T1.Livre_IspnLivre, T1.Livre_EtatLivre)
    FROM (
        SELECT 
            T.IdLivre AS Livre_IdLivre, 
            T.IdOuvrage AS Livre_IdOuvrage, 
            T.IspnLivre AS Livre_IspnLivre, 
            T.EtatLivre AS Livre_EtatLivre, 
            True AS _from0
        FROM [BibliothèqueEntities].Livre AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Ouvrage.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Ouvrage
        [BibliothèqueModel.Store.Ouvrage](T1.Ouvrage_IdOuvrage, T1.Ouvrage_IdSecteur, T1.Ouvrage_IdTheme, T1.Ouvrage_TitreOuvrage, T1.Ouvrage_PrixOuvrage, T1.Ouvrage_LieuOuvrage, T1.Ouvrage_AuteurOuvrage, T1.Ouvrage_EditeurOuvrage)
    FROM (
        SELECT 
            T.IdOuvrage AS Ouvrage_IdOuvrage, 
            T.IdSecteur AS Ouvrage_IdSecteur, 
            T.IdTheme AS Ouvrage_IdTheme, 
            T.TitreOuvrage AS Ouvrage_TitreOuvrage, 
            T.PrixOuvrage AS Ouvrage_PrixOuvrage, 
            T.LieuOuvrage AS Ouvrage_LieuOuvrage, 
            T.AuteurOuvrage AS Ouvrage_AuteurOuvrage, 
            T.EditeurOuvrage AS Ouvrage_EditeurOuvrage, 
            True AS _from0
        FROM [BibliothèqueEntities].Ouvrage AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Secteur.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Secteur
        [BibliothèqueModel.Store.Secteur](T1.Secteur_IdSecteur, T1.Secteur_NomSecteur)
    FROM (
        SELECT 
            T.IdSecteur AS Secteur_IdSecteur, 
            T.NomSecteur AS Secteur_NomSecteur, 
            True AS _from0
        FROM [BibliothèqueEntities].Secteur AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Stagiaire.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Stagiaire
        [BibliothèqueModel.Store.Stagiaire](T1.Stagiaire_IdStagiaire, T1.Stagiaire_NomStagiaire, T1.Stagiaire_PrenomStagiaire, T1.Stagiaire_EmailStagiaire, T1.Stagiaire_PasswordStagiaire, T1.Stagiaire_IdFGroupe)
    FROM (
        SELECT 
            T.IdStagiaire AS Stagiaire_IdStagiaire, 
            T.NomStagiaire AS Stagiaire_NomStagiaire, 
            T.PrenomStagiaire AS Stagiaire_PrenomStagiaire, 
            T.EmailStagiaire AS Stagiaire_EmailStagiaire, 
            T.PasswordStagiaire AS Stagiaire_PasswordStagiaire, 
            T.IdFGroupe AS Stagiaire_IdFGroupe, 
            True AS _from0
        FROM [BibliothèqueEntities].Stagiaire AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.Theme.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Theme
        [BibliothèqueModel.Store.Theme](T1.Theme_IdTheme, T1.Theme_NomTheme)
    FROM (
        SELECT 
            T.IdTheme AS Theme_IdTheme, 
            T.NomTheme AS Theme_NomTheme, 
            True AS _from0
        FROM [BibliothèqueEntities].Theme AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueModelStoreContainer.LivrePerdu.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing LivrePerdu
        [BibliothèqueModel.Store.LivrePerdu](T1.LivrePerdu_IdLivre, T1.LivrePerdu_datPerdu)
    FROM (
        SELECT 
            T.IdLivre AS LivrePerdu_IdLivre, 
            T.datPerdu AS LivrePerdu_datPerdu, 
            True AS _from0
        FROM [BibliothèqueEntities].LivrePerdus AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Emprinte.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Emprinte
        [BibliothèqueModel.Emprinte](T1.Emprinte_IdEmprinte, T1.Emprinte_IdSagiaire, T1.Emprinte_IdLivre, T1.Emprinte_DateEmprinte, T1.Emprinte_DateRoteur)
    FROM (
        SELECT 
            T.IdEmprinte AS Emprinte_IdEmprinte, 
            T.IdSagiaire AS Emprinte_IdSagiaire, 
            T.IdLivre AS Emprinte_IdLivre, 
            T.DateEmprinte AS Emprinte_DateEmprinte, 
            T.DateRoteur AS Emprinte_DateRoteur, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Emprinte AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Filiere.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Filiere
        [BibliothèqueModel.Filiere](T1.Filiere_IdFiliere, T1.Filiere_NomFiliere, T1.Filiere_IdSecteur)
    FROM (
        SELECT 
            T.IdFiliere AS Filiere_IdFiliere, 
            T.NomFiliere AS Filiere_NomFiliere, 
            T.IdSecteur AS Filiere_IdSecteur, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Filiere AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Groupe.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Groupe
        [BibliothèqueModel.Groupe](T1.Groupe_IdGroupe, T1.Groupe_NomGroupe, T1.Groupe_IdFiliere)
    FROM (
        SELECT 
            T.IdGroupe AS Groupe_IdGroupe, 
            T.NomGroupe AS Groupe_NomGroupe, 
            T.IdFiliere AS Groupe_IdFiliere, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Groupe AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Livre.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView12()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Livre
        [BibliothèqueModel.Livre](T1.Livre_IdLivre, T1.Livre_IdOuvrage, T1.Livre_IspnLivre, T1.Livre_EtatLivre)
    FROM (
        SELECT 
            T.IdLivre AS Livre_IdLivre, 
            T.IdOuvrage AS Livre_IdOuvrage, 
            T.IspnLivre AS Livre_IspnLivre, 
            T.EtatLivre AS Livre_EtatLivre, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Livre AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Ouvrage.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView13()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Ouvrage
        [BibliothèqueModel.Ouvrage](T1.Ouvrage_IdOuvrage, T1.Ouvrage_IdSecteur, T1.Ouvrage_IdTheme, T1.Ouvrage_TitreOuvrage, T1.Ouvrage_PrixOuvrage, T1.Ouvrage_LieuOuvrage, T1.Ouvrage_AuteurOuvrage, T1.Ouvrage_EditeurOuvrage)
    FROM (
        SELECT 
            T.IdOuvrage AS Ouvrage_IdOuvrage, 
            T.IdSecteur AS Ouvrage_IdSecteur, 
            T.IdTheme AS Ouvrage_IdTheme, 
            T.TitreOuvrage AS Ouvrage_TitreOuvrage, 
            T.PrixOuvrage AS Ouvrage_PrixOuvrage, 
            T.LieuOuvrage AS Ouvrage_LieuOuvrage, 
            T.AuteurOuvrage AS Ouvrage_AuteurOuvrage, 
            T.EditeurOuvrage AS Ouvrage_EditeurOuvrage, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Ouvrage AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Secteur.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView14()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Secteur
        [BibliothèqueModel.Secteur](T1.Secteur_IdSecteur, T1.Secteur_NomSecteur)
    FROM (
        SELECT 
            T.IdSecteur AS Secteur_IdSecteur, 
            T.NomSecteur AS Secteur_NomSecteur, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Secteur AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Stagiaire.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView15()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Stagiaire
        [BibliothèqueModel.Stagiaire](T1.Stagiaire_IdStagiaire, T1.Stagiaire_NomStagiaire, T1.Stagiaire_PrenomStagiaire, T1.Stagiaire_EmailStagiaire, T1.Stagiaire_PasswordStagiaire, T1.Stagiaire_IdFGroupe)
    FROM (
        SELECT 
            T.IdStagiaire AS Stagiaire_IdStagiaire, 
            T.NomStagiaire AS Stagiaire_NomStagiaire, 
            T.PrenomStagiaire AS Stagiaire_PrenomStagiaire, 
            T.EmailStagiaire AS Stagiaire_EmailStagiaire, 
            T.PasswordStagiaire AS Stagiaire_PasswordStagiaire, 
            T.IdFGroupe AS Stagiaire_IdFGroupe, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Stagiaire AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.Theme.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView16()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Theme
        [BibliothèqueModel.Theme](T1.Theme_IdTheme, T1.Theme_NomTheme)
    FROM (
        SELECT 
            T.IdTheme AS Theme_IdTheme, 
            T.NomTheme AS Theme_NomTheme, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].Theme AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for BibliothèqueEntities.LivrePerdus.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView17()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing LivrePerdus
        [BibliothèqueModel.LivrePerdu](T1.LivrePerdu_IdLivre, T1.LivrePerdu_datPerdu)
    FROM (
        SELECT 
            T.IdLivre AS LivrePerdu_IdLivre, 
            T.datPerdu AS LivrePerdu_datPerdu, 
            True AS _from0
        FROM [BibliothèqueModelStoreContainer].LivrePerdu AS T
    ) AS T1");
        }
    }
}
