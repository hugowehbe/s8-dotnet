﻿using System;
using Dep_Gestion.DAO;
using Metier;



namespace DAO
{
    class SQLFactory : AbstractDAOFactory
    {

        public override DAO<EquivalentTD> getEquivalentTDDao()
        {
            return new EquivalentTDSQL();
        }

        public override DAO<Categorie> getCategorieDAO()
        {
            return new CategorieSQL();
        }

        public override DAO<TypeCours> getTypeCoursDao()
        {
            return new TypeCoursSQL();
        }

        public override DAO<Groupe> getGroupeDAO()
        {
            return new GroupeSQL();
        }

        public override DAO<Annee> getAnneeDAO()
        {
            return new AnneeSQL();
        }

        public override DAO<PartieAnnee> getPartieAnneeDAO()
        {
            return new PartieAnneeSQL();
        }
    }
}