﻿using Core.DataAccess.Entitiy_Freamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entity_Freamwork
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCarContext>, IUserDal
    {
     
    }
}
        
    

