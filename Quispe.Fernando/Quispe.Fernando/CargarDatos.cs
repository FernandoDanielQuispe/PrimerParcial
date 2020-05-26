using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quispe.Fernando
{
    public class CargarDatos
    {
        List<Docente> listDocentesSinAula;
        List<Alumno> alumnos;
        List<Administrativo> listAdministrativo;

        public List<Docente> Docentes
        {
            get 
            {
                return this.listDocentesSinAula;
            }        
        }
        public List<Alumno> listAlumnos
        {
            get
            {
                return this.alumnos;
            }        
        }
        public List<Administrativo> Administrativo
        {
            get
            {
                return this.listAdministrativo;
            }        
        }
        public CargarDatos()
        {
            alumnos = new List<Alumno>();
            listDocentesSinAula = new List<Docente>();
            listAdministrativo = new List<Administrativo>();

            Docente d1 = new Docente("Dell", "Symon", 53749006, false, DateTime.Parse("07:00"), DateTime.Parse("12:00"), 300.00);
            Docente d2 = new Docente("Dilly", "Butner", 79347458, false, DateTime.Parse("07:00"), DateTime.Parse("12:00"), 300.00);
            Docente d3 = new Docente("Garrik", "Ravilious", 15689343, false, DateTime.Parse("07:00"), DateTime.Parse("12:00"), 300.00);
            Docente d4 = new Docente("Vic", "Tutton", 85487144, false, DateTime.Parse("13:00"), DateTime.Parse("18:00"), 400.00);
            Docente d5 = new Docente("Irving", "Cuskery", 53529437, false, DateTime.Parse("13:00"), DateTime.Parse("18:00"), 400.00);
            listDocentesSinAula.Add(d1);
            listDocentesSinAula.Add(d2);
            listDocentesSinAula.Add(d3);
            listDocentesSinAula.Add(d4);
            listDocentesSinAula.Add(d5);

            listAdministrativo.Add(new Administrativo("Jeffy", "Hatry", 53521878, false, DateTime.Parse("07:00"), DateTime.Parse("12:00"), ECargo.Direccion));
            listAdministrativo.Add(new Administrativo("Bert","Avory",93089734, false, DateTime.Parse("07:00"), DateTime.Parse("12:00"), ECargo.Tesoreria));
            listAdministrativo.Add(new Administrativo("Garrek","Pideon",84985411, false, DateTime.Parse("07:00"), DateTime.Parse("12:00"), ECargo.Secretaria));
            listAdministrativo.Add(new Administrativo("Sandye","Dalyell",80813336, true, DateTime.Parse("07:00"), DateTime.Parse("12:00"), ECargo.Porteria));
            listAdministrativo.Add(new Administrativo("Marquita","Widmore",81006088, true, DateTime.Parse("07:00"), DateTime.Parse("12:00"), ECargo.Cocina));
            listAdministrativo.Add(new Administrativo("Reamonn","Wickrath",33934086, false, DateTime.Parse("13:00"), DateTime.Parse("18:00"), ECargo.Porteria));
            listAdministrativo.Add(new Administrativo("Clayson","Elgar",92504592, false, DateTime.Parse("13:00"), DateTime.Parse("18:00"), ECargo.Secretaria));
            listAdministrativo.Add(new Administrativo("Tobiah","Pantone",42165952, false, DateTime.Parse("13:00"), DateTime.Parse("18:00"), ECargo.Cocina));
            listAdministrativo.Add(new Administrativo("Didi","Alden",39793967, true, DateTime.Parse("13:00"), DateTime.Parse("18:00"), ECargo.Cocina));
            listAdministrativo.Add(new Administrativo("Katerine","Enocksson",73031242, true, DateTime.Parse("13:00"), DateTime.Parse("18:00"), ECargo.Porteria));
        }

        public void CargarInfo()
        {
            Responsable r1 = new Responsable("Tanya","Eppson",72157953, EParentesco.Madre, "73712027");
            Responsable r2 = new Responsable("Poul","Malarkey",77271679, EParentesco.Padre, "99232552");
            Responsable r3 = new Responsable("Frasquito","Ikins",43438493, EParentesco.Tio, "72391944");
            Responsable r4 = new Responsable("Christabel","Bianco",71330918, EParentesco.Abuela, "45134991");
            Responsable r5 = new Responsable("Ennis","Swidenbank",61550356, EParentesco.Abuelo, "26813618");
            Responsable r6 = new Responsable("Georgia", "Barthelemy", 86191463, EParentesco.Madre, "92721259");
            Responsable r7 = new Responsable("Alida", "Cristou", 92840873, EParentesco.Madre, "84654851");
            Responsable r8 = new Responsable("Levy", "Quarmby", 27321614, EParentesco.Tio, "97177186");
            Responsable r9 = new Responsable("Sonya", "Joris", 80243773, EParentesco.Madre, "35395806");
            Responsable r10 = new Responsable("Skylar", "Tollerfield", 24817904, EParentesco.Padre, "39921771");
            Responsable r11 = new Responsable("Ruthann", "Camillo", 15232744, EParentesco.Madre, "26487398");
            Responsable r12 = new Responsable("Wendeline", "Rupp", 61003548, EParentesco.Madre, "53886851");
            Responsable r13 = new Responsable("Jennette", "Swindin", 38678261, EParentesco.Tia, "9338397");
            Responsable r14 = new Responsable("Dorice", "Spinige", 34002947, EParentesco.Madre, "25317577");
            Responsable r15 = new Responsable("Mariana", "Gavriel", 62277072, EParentesco.Madre, "57588424");
            Responsable r16 = new Responsable("Essie", "Lipson", 32597937, EParentesco.Tia, "53665529");
            Responsable r17 = new Responsable("Fallon", "Quernel", 61106152, EParentesco.Madre, "43381183");
            Responsable r18 = new Responsable("Vina", "Rannells", 72077763, EParentesco.Madre, "56943188");
            Responsable r19 = new Responsable("Windham", "Downie", 89100784, EParentesco.Padre, "21380949");
            Responsable r20 = new Responsable("Mattie", "Jovey", 67837241, EParentesco.Abuelo, "49244196");
            Responsable r21 = new Responsable("Roana", "Pengilley", 27231803, EParentesco.Abuela, "46688811");
            Responsable r22 = new Responsable("Cleon", "Stolz", 39909090, EParentesco.Padre, "40877909");
            Responsable r23 = new Responsable("Alica", "Quail", 93350797, EParentesco.Madre, "72279062");
            Responsable r24 = new Responsable("Paola", "Tutsell", 82186576, EParentesco.Tia, "57916466");
            Responsable r25 = new Responsable("Callie", "Boatwright", 92091760, EParentesco.Madre, "43178827");
            Responsable r26 = new Responsable("Emilio", "Ramme", 25023137, EParentesco.Padre, "99731698");
            Responsable r27 = new Responsable("Cobby", "Cotterrill", 27949477, EParentesco.Padre, "78759789");
            Responsable r28 = new Responsable("Northrop", "Hestrop", 62772251, EParentesco.Padre, "95220892");
            Responsable r29 = new Responsable("Alonzo", "Gramer", 45259912, EParentesco.Padre, "35592606");
            Responsable r30 = new Responsable("Lina", "Bartke", 86754456, EParentesco.Madre, "62697267");
            Responsable r31 = new Responsable("Juanita", "Putt", 48584908, EParentesco.Madre, "67913237");
            Responsable r32 = new Responsable("Gawain", "Sussems", 39396733, EParentesco.Tio, "97632056");
            Responsable r33 = new Responsable("Chryste", "Waples", 84706599, EParentesco.Madre, "13215323");
            Responsable r34 = new Responsable("Annemarie", "Niess", 76590937, EParentesco.Madre, "83492591");
            Responsable r35 = new Responsable("Dimitri", "Burgoine", 89204430, EParentesco.Padre, "46711416");
            Responsable r36 = new Responsable("Odell", "Grunder", 36421238, EParentesco.Abuelo, "87652803");
            Responsable r37 = new Responsable("Shanna", "Josham", 20891952, EParentesco.Abuela, "21529481");
            Responsable r38 = new Responsable("Caroline", "Ponton", 86305326, EParentesco.Madre, "63667772");
            Responsable r39 = new Responsable("Richmond", "Arno", 68158717, EParentesco.Padre, "30151792");
            Responsable r40 = new Responsable("Marlee", "Balmadier", 37544113, EParentesco.Tia, "37948974");
            Responsable r41 = new Responsable("Melva", "Rainey", 58035182, EParentesco.Madre, "66182896");
            Responsable r42 = new Responsable("Arturo", "Hearthfield", 36481451, EParentesco.Padre, "91997816");
            Responsable r43 = new Responsable("Monro", "Skune", 72572042, EParentesco.Padre, "18239572");
            Responsable r44 = new Responsable("Gwenneth", "Jeanel", 54725453, EParentesco.Madre, "27496858");
            Responsable r45 = new Responsable("Gamaliel", "Benoi", 20713475, EParentesco.Padre, "24065622");
            Responsable r46 = new Responsable("Milty", "Bride", 67262818, EParentesco.Padre, "39649834");
            Responsable r47 = new Responsable("Hatti", "Plevey", 91843079, EParentesco.Madre, "49272919");
            Responsable r48 = new Responsable("Mireille", "Spillett", 96209612, EParentesco.Tia, "30879342");
            Responsable r49 = new Responsable("Gannon", "Minihane", 55799364, EParentesco.Padre, "77865576");
            Responsable r50 = new Responsable("Dewitt", "Cummine", 11864549, EParentesco.Padre, "48691037");

            alumnos.Add(new Alumno("Rabbi", "Biddleston", 46766420, false, EColores.Naranja, 1001, 9000f, r1));
            alumnos.Add(new Alumno("Lemmy", "Welland", 63905960, false, EColores.Naranja, 1002, 9000f, r2));
            alumnos.Add(new Alumno("Rusty", "Heikkinen", 97069623, false, EColores.Naranja, 1003, 9000f, r3));
            alumnos.Add(new Alumno("Caryn", "Ashfield", 80434702, true, EColores.Naranja, 1004, 9000f, r4));
            alumnos.Add(new Alumno("Christi", "Renshall", 77818480, true, EColores.Naranja, 1005, 9000f, r5));
            alumnos.Add(new Alumno("Kyla", "Dibdale", 42190839, true, EColores.Naranja, 1006, 9000f, r6));
            alumnos.Add(new Alumno("Toma", "Wilsee", 55766400, true, EColores.Naranja, 1007, 9000f, r7));
            alumnos.Add(new Alumno("Kaela", "Mollene", 53678330, true, EColores.Naranja, 1008, 9000f, r8));
            alumnos.Add(new Alumno("Teodoor", "Torresi", 85785183, false, EColores.Naranja, 1009, 9000f, r9));
            alumnos.Add(new Alumno("Olin", "Wixey", 49534731, false, EColores.Naranja, 1010, 9000f, r10));
            alumnos.Add(new Alumno("Trstram", "Olenchenko", 88654557, false, EColores.Naranja, 1011, 9000f, r11));
            alumnos.Add(new Alumno("Kellby", "Arnley", 89913963, false, EColores.Naranja, 1012, 9000f, r12));
            alumnos.Add(new Alumno("Arri", "Gligori", 62008700, false, EColores.Naranja, 1013, 9000f, r13));
            alumnos.Add(new Alumno("Jacquetta", "Pendle", 81319268, true, EColores.Naranja, 1014, 9000f, r14));
            alumnos.Add(new Alumno("Halli", "Littleton", 79964718, true, EColores.Naranja, 1015, 9000f, r15));
            alumnos.Add(new Alumno("Tami", "Walthew", 82502224, true, EColores.Naranja, 1016, 9000f, r16));
            alumnos.Add(new Alumno("Feliza", "Rubinowitch", 84542853, true, EColores.Naranja, 1017, 9000f, r17));
            alumnos.Add(new Alumno("Brew", "Deguara", 64586201, false, EColores.Naranja, 1018, 9000f, r18));
            alumnos.Add(new Alumno("Carroll", "Bartelet", 64974908, false, EColores.Naranja, 1019, 9000f, r19));
            alumnos.Add(new Alumno("Elyn", "Ternault", 90791820, true, EColores.Naranja, 1020, 9000f, r20));
            alumnos.Add(new Alumno("Nanete", "Sampson", 75133833, true, EColores.Rojo, 1021, 9000f, r21));
            alumnos.Add(new Alumno("Darryl", "Paolotto", 49633896, false, EColores.Rojo, 1022, 9000f, r22));
            alumnos.Add(new Alumno("Lyell", "Larmor", 60102963, false, EColores.Rojo, 1023, 9000f, r23));
            alumnos.Add(new Alumno("Dorthea", "Tamas", 89900719, true, EColores.Rojo, 1024, 9000f, r24));
            alumnos.Add(new Alumno("Valerie", "Frichley", 50897177, true, EColores.Rojo, 1025, 9000f, r25));
            alumnos.Add(new Alumno("Isadora", "Josefson", 58534405, true, EColores.Rojo, 1026, 9000f, r26));
            alumnos.Add(new Alumno("Netta", "Stuck", 99856859, true, EColores.Rojo, 1027, 9000f, r27));
            alumnos.Add(new Alumno("Philippine", "Denslow", 83786184, true, EColores.Rojo, 1028, 9000f, r28));
            alumnos.Add(new Alumno("Fulvia", "Eddy", 51372408, true, EColores.Rojo, 1029, 9000f, r29));
            alumnos.Add(new Alumno("Clyde", "Gittoes", 86035249, false, EColores.Rojo, 1030, 9000f, r30));
            alumnos.Add(new Alumno("Alister", "Gillum", 75798437, false, EColores.Amarillo, 1031, 9000f, r31));
            alumnos.Add(new Alumno("Merla", "Mattacks", 43860730, true, EColores.Amarillo, 1032, 9000f, r32));
            alumnos.Add(new Alumno("Raimondo", "O'Dowling", 98008986, false, EColores.Amarillo, 1033, 9000f, r33));
            alumnos.Add(new Alumno("Roddy", "Whitwham", 97707572, false, EColores.Amarillo, 1034, 9000f, r34));
            alumnos.Add(new Alumno("Arther", "Pretor", 53699342, false, EColores.Amarillo, 1035, 9000f, r35));
            alumnos.Add(new Alumno("Konstance", "Rosenvasser",45357997, true, EColores.Amarillo, 1036, 9000f, r36));
            alumnos.Add(new Alumno("Davita", "Fogden", 64120765, true, EColores.Amarillo, 1037, 9000f, r37));
            alumnos.Add(new Alumno("Alecia", "Ramsbottom", 57020089, true, EColores.Amarillo, 1038, 9000f, r38));
            alumnos.Add(new Alumno("Doria", "Mewis", 93835983, true, EColores.Amarillo, 1039, 9000f, r39));
            alumnos.Add(new Alumno("Ches", "Canizares", 53059826, false, EColores.Amarillo, 1040, 9000f, r40));
            alumnos.Add(new Alumno("Else", "Enga", 74024211, true, EColores.Verde, 1041, 9000f, r41));
            alumnos.Add(new Alumno("Meara", "Tiller", 62486499, true, EColores.Verde, 1042, 9000f, r42));
            alumnos.Add(new Alumno("Cal", "Mobberley", 62587194, false, EColores.Verde, 1043, 9000f, r43));
            alumnos.Add(new Alumno("Peria", "Smouten", 86568176, true, EColores.Verde, 1044, 9000f, r44));
            alumnos.Add(new Alumno("Sean", "Warland", 69150507, false, EColores.Verde, 1045, 9000f, r45));
            alumnos.Add(new Alumno("Kennett", "Gullivan", 46793495, false, EColores.Verde, 1046, 9000f, r46));
            alumnos.Add(new Alumno("Wendye", "Attenburrow", 68255016, true, EColores.Verde, 1047, 9000f, r47));
            alumnos.Add(new Alumno("Silvio", "Treleaven", 87994535, false, EColores.Verde, 1048, 9000f, r48));
            alumnos.Add(new Alumno("Harriette", "Hydes", 91773259, true, EColores.Verde, 1049, 9000f, r49));
            alumnos.Add(new Alumno("Bessie", "Casement", 53223192, true, EColores.Verde, 1050, 9000f, r50));
        }
    }
}
