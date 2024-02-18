namespace w3schools.FunStuff.Data.CrownAndSkull
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class EquipmentData
    {
        public class BasicWeaponsData : IData<BasicWeaponEquipment>
        {
            public int Add(BasicWeaponEquipment item)
            {
                throw new NotImplementedException();
            }

            public BasicWeaponEquipment Edit(BasicWeaponEquipment item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<BasicWeaponEquipment> Get() => (EquipmentRawData.Search(x => x.IsWeapon && !x.IsCrown && !x.IsSkull).ToList()) as IEnumerable<BasicWeaponEquipment>;

            public BasicWeaponEquipment Get(int Id) => new BasicWeaponEquipment(EquipmentRawData.Get(Id));
            
            public IEnumerable<BasicWeaponEquipment> Search(Expression<Func<BasicWeaponEquipment, bool>> expression) => (Get() as IQueryable<BasicWeaponEquipment>).Where(expression);
         
        }

        public class BasicArmorData : IData<BasicArmorEquipment>
        {
            public int Add(BasicArmorEquipment item)
            {
                throw new NotImplementedException();
            }

            public BasicArmorEquipment Edit(BasicArmorEquipment item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<BasicArmorEquipment> Get() => (EquipmentRawData.Search(x => !x.IsCrown && !x.IsSkull && x.IsArmor).ToList() as IEnumerable<BasicArmorEquipment>);

            public BasicArmorEquipment Get(int Id) => new BasicArmorEquipment(EquipmentRawData.Get(Id));

            public IEnumerable<BasicArmorEquipment> Search(Expression<Func<BasicArmorEquipment, bool>> expression) => (Get() as IQueryable<BasicArmorEquipment>).Where(expression);
        }

        public class BasicEquipmentData : IData<BasicEquipment>
        {
            public int Add(BasicEquipment item)
            {
                throw new NotImplementedException();
            }

            public BasicEquipment Edit(BasicEquipment item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<BasicEquipment> Get() => (EquipmentRawData.Search(x => !x.IsCrown && !x.IsSkull && x.IsEquipment).ToList()) as IEnumerable<BasicEquipment>;

            public BasicEquipment Get(int Id) => new BasicEquipment(EquipmentRawData.Get(Id));

            public IEnumerable<BasicEquipment> Search(Expression<Func<BasicEquipment, bool>> expression) => (Get() as IQueryable<BasicEquipment>).Where(expression);    
        }

        public class LargeEquipmentData : IData<LargeEquipment>
        {
            public int Add(LargeEquipment item)
            {
                throw new NotImplementedException();
            }

            public LargeEquipment Edit(LargeEquipment item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<LargeEquipment> Get() => (EquipmentRawData.Search(x => !x.IsCrown && !x.IsSkull && x.IsLarge).ToList()) as IEnumerable<LargeEquipment>;

            public LargeEquipment Get(int Id) => new LargeEquipment(EquipmentRawData.Get(Id));

            public IEnumerable<LargeEquipment> Search(Expression<Func<LargeEquipment, bool>> expression) => (Get() as IQueryable<LargeEquipment>).Where(expression);    
        }

        public class CrownEquipmentData : IData<CrownEquipment>
        {
            public int Add(CrownEquipment item)
            {
                throw new NotImplementedException();
            }

            public CrownEquipment Edit(CrownEquipment item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<CrownEquipment> Get() => (EquipmentRawData.Search(x => x.IsCrown && x.IsEquipment).ToList()) as IEnumerable<CrownEquipment>;

            public CrownEquipment Get(int Id) => new CrownEquipment(EquipmentRawData.Get(Id));

            public IEnumerable<CrownEquipment> Search(Expression<Func<CrownEquipment, bool>> expression) => (Get() as IQueryable<CrownEquipment>)?.Where(expression);
        }

        public class CrownWeaponData : IData<CrownWeapons>
        {
            public int Add(CrownWeapons item)
            {
                throw new NotImplementedException();
            }

            public CrownWeapons Edit(CrownWeapons item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<CrownWeapons> Get() => (EquipmentRawData.Search(x => x.IsCrown && !x.IsSkull && x.IsWeapon).ToList()) as IEnumerable<CrownWeapons>;

            public CrownWeapons Get(int Id) => new CrownWeapons(EquipmentRawData.Get(Id));

            public IEnumerable<CrownWeapons> Search(Expression<Func<CrownWeapons, bool>> expression) => (Get() as IQueryable<CrownWeapons>)?.Where(expression);
        }

        public class CrownArmorData : IData<CrownArmor>
        {
            public int Add(CrownArmor item)
            {
                throw new NotImplementedException();
            }

            public CrownArmor Edit(CrownArmor item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<CrownArmor> Get() => (EquipmentRawData.Search(x => x.IsArmor && x.IsCrown)).ToList() as IEnumerable<CrownArmor>;

            public CrownArmor Get(int Id) => new CrownArmor(EquipmentRawData.Get(Id));

            public IEnumerable<CrownArmor> Search(Expression<Func<CrownArmor, bool>> expression) => (Get() as IQueryable<CrownArmor>)?.Where(expression);
        }

        public class SkullEquipmentData : IData<SkullEquipment>
        {
            public int Add(SkullEquipment item)
            {
                throw new NotImplementedException();
            }

            public SkullEquipment Edit(SkullEquipment item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<SkullEquipment> Get() => (EquipmentRawData.Search(x => x.IsEquipment && x.IsSkull)).ToList() as IEnumerable<SkullEquipment>;

            public SkullEquipment Get(int Id) => new SkullEquipment(EquipmentRawData.Get(Id));

            public IEnumerable<SkullEquipment> Search(Expression<Func<SkullEquipment, bool>> expression) => (Get() as IQueryable<SkullEquipment>)?.Where(expression);
        }

        public class SkullWeaponData : IData<SkullWeapons>
        {
            public int Add(SkullWeapons item)
            {
                throw new NotImplementedException();
            }

            public SkullWeapons Edit(SkullWeapons item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<SkullWeapons> Get() => (EquipmentRawData.Search(x => x.IsWeapon && x.IsSkull)).ToList() as IEnumerable<SkullWeapons>;

            public SkullWeapons Get(int Id) => new SkullWeapons(EquipmentRawData.Get(Id));

            public IEnumerable<SkullWeapons> Search(Expression<Func<SkullWeapons, bool>> expression) => (Get() as IQueryable<SkullWeapons>)?.Where(expression);
        }

        public class SkullArmorData : IData<SkullArmors>
        {
            public int Add(SkullArmors item)
            {
                throw new NotImplementedException();
            }

            public SkullArmors Edit(SkullArmors item)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<SkullArmors> Get() => EquipmentRawData.Search(x => x.IsSkull && x.IsArmor).ToList() as IEnumerable<SkullArmors>;

            public SkullArmors Get(int Id) => new SkullArmors(EquipmentRawData.Get(Id));

            public IEnumerable<SkullArmors> Search(Expression<Func<SkullArmors, bool>> expression) => (Get() as IQueryable<SkullArmors>)?.Where(expression);
        }
    }
}
