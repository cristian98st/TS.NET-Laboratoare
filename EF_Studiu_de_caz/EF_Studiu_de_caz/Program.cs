using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Studiu_de_caz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            /// Scenariul 1

            //SelfReference parent = new SelfReference();
            //SelfReference el1 = new SelfReference();
            //SelfReference el2 = new SelfReference();
            //List<SelfReference> references = new List<SelfReference>();
            //references.Add(el1);
            //references.Add(el2);

            //SelfReferenceService selfReferenceService = new SelfReferenceService();

            //selfReferenceService.addElement("El1", parent, references);
            //selfReferenceService.getElements();


            /// Scenariul 2

            //ProductService productService = new ProductService();
            //productService.insert();
            //productService.find();


            /// Scenariul 3

            //PhotographService photographService = new PhotographService();
            //photographService.insert();
            //photographService.getPhotos();

            /// Scenariul 4

            //BusinessService businessService = new BusinessService();
            //businessService.insert();
            //businessService.getBusiness();

            /// Scenariul 5
            
            //EmployeeService employeeService = new EmployeeService();
            //employeeService.insert();
            //employeeService.getEmployees();

        }
    }
}
