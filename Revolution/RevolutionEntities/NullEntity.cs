using System;
using SystemInterfaces;
using Common;
using Common.DataEntites;
using RevolutionEntities.Process;

namespace RevolutionEntities
{
    public sealed class NullEntity<T> : BaseEntity
    {

        private static readonly T instance;

        public static void Initialize()
        {
            
        }

        static NullEntity()
        {
            try
            {
                var export = BootStrapper.BootStrapper.Container.GetExport<T>();
                if (export != null)
                {
                    var itm = export.Value;
                    instance = (T)Activator.CreateInstance(itm.GetType());

                }
                else
                {
                    instance = default(T);
                }
                var entity = instance as IEntity;
                if (entity != null) entity.Id = -1;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static T Instance => instance;
        public NullEntity()
        {
            Id = -1;
        }
        
    }


}

