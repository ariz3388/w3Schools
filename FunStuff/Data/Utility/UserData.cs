namespace w3schools.FunStuff.Data.Utility
{
    using Models.Utility;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class UserData : IData<UserObj>
    {
        public int Add(UserObj item)
        {
            throw new NotImplementedException();
        }

        public UserObj Edit(UserObj item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserObj> Get()
        {
            throw new NotImplementedException();
        }

        public UserObj Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserObj> Search(Expression<Func<UserObj, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
