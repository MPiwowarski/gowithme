﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoWithMe.Model.ModelDB;

namespace GoWithMe.Model.Repo
{
    public interface ITblImageRepository
    {
        void AddNewImage(tblImage newImg);
        byte[] GetUserImage(int UserId);
    }

    public class TblImageRepository : DataRepository, ITblImageRepository
    {
        private GoWithMeDBContext _context;

        public TblImageRepository()
        {
            this._context = DBContext;
        }

        public TblImageRepository(GoWithMeDBContext context)
        {
            this._context = context;
        }



        public void AddNewImage(tblImage newImg)
        {
            DBContext.Images.Add(newImg);
            DBContext.SaveChanges();
        }
        public byte[] GetUserImage(int userId)
        {
            return DBContext.Images.Where(x => x.UserId == userId).Select(x => x.Image).FirstOrDefault();
        }
    }
}