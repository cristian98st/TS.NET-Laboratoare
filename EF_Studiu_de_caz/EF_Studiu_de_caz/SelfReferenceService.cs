using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Studiu_de_caz
{
    public class SelfReferenceService
    {
        public void addElement(string Name, SelfReference parentSelfReference, List<SelfReference> references)
        {
            using (var context = new ModelSelfReferences())
            {
                SelfReference selfReference = new SelfReference();
                selfReference.Name = Name;
                selfReference.ParentSelfReference = parentSelfReference;
                selfReference.References = references;
                context.SelfReferences.Add(selfReference);
                context.SaveChanges();
            }
        }

        public void getElements()
        {
            using (var context = new ModelSelfReferences())
            {
                var elements = context.SelfReferences.ToList();
                foreach (var e in elements)
                {
                    Console.WriteLine(e.SelfReferenceId);
                    Console.WriteLine(e.Name);
                    Console.WriteLine(e.ParentSelfReference);
                    Console.WriteLine(e.References);
                }
            }
        }
    }
}
