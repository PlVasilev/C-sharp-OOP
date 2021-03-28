using System;
using System.Reflection;

namespace TODOs
{
    class TODOs
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            // 1 първо Прочитаме ВНИМАТЕЛНО задачата
            // 2 Правим ConsoleReader и ConsoleWriter на база IReader и IWriter трием и правим на ново
            // 3 Поправяме Engine
            // 3.1 имплементираме IEngine,
            // 3.2 fields - private,
            // 3.3 create CTOR(fields){инициализация} за да има възможност за тестове
            // 4 Поправяме  StartUp - IEngine engine = new Engine(reader, writer....);
            // 5 добавяме си всички controllers и емплементираме им интерфейсите за даработи StartUp
            // 6 fix Controllers intefaces fields private
            // 6.1 ctors Initalization (instruments = new List<IInstrument>) 
            // 6.2 prop get private set if needed
            // 6.2 GET on Collection public IReadOnlyCollection<IInstrument> instruments => this.instruments.AsReadOnlt();
            // 7 fix Controllers Methods старт със ProccesCommand 
            // 8 fix methods до степен да тръгне проекта
            // 9 MUST get to Debugging
            // 10 Start Debugging от първата команда на заданието към последната
            // 11 fix other Classes name interface field prop ctor  methods 
            // 11.1 Base Class name interface field prop ctor  methods 
            // 11.2 Child Class Del ненужните класове правим ако ливпсват; name base class interface field prop ctor  methods 
            // 11.3 Factories reflection - Ако Няма childClass махаме факторитата
            // 11.3.0 public class SetFactory : ISetFactory
            // 11.3.0 public ISet CreateSet(string name, string typeName) - in ctor
            // 11.3.1 Type type = Assembly.GetCallingAssemblu().GetTypes().FirstOrRefault(t => t.Name == typeName)
            // 11.3.2 ISet set = (Iset)Activator.CreateInstance(type, name)
            // 11.3.3 return set
            // 12 TEST REFLECTION and Structure maybe
            // 13 Fix Structure 
            // 14 TEST structure (maybe fails)
            // 15 fix Controllers - Factories
            // 15.1 field setFactory  ctor (Isetfactory setfactory) {this setfactory = setfactory} // same to all factories
            // 15.2 fix All methods starting from begging in wordFile in the Controller check for names 
            // 15.3 може да имаме допълнителни методи от Output
            // 16 TEST structure
            // 17 fix methods in Output
            // 18 TEST IO
            // 19 Unit tests remove all unnesasery usings оставаме само Държавните System Collection.Genreric Nunit  и т.н при предаване в  Judje
            // После връщаме usingite почваме от method publics props и тн
            // 20 проверяваме 2 3 метходата дали връщат правилни неща
            // или ако метода е един правим няколко проверки на вътрешните методи
            // един тест за 1 метод !
            // 21 !! Дебъгваме теста с брейк пойнт на Actual Rresult копираме изхода и го поставяме в Expected


            // TargetInvocationException exception по време  на reflection
            // Може да има букви на кирилица
            // в reflection можем да турсим освен с == и с contains ili с + command и тн
            // in READONLY we add to field , but we get true Getter in the prop
            // SelectMeny int[][] nums = {{1,2,3} {4,5,6}} select взима вътрепния Arrey SelectMany елементите на вътрешните масиви
            // foreach = 1,2,3,4,5,6 
            // can create private methods if we need them
            // ако е както тук с упвиличаващо ID при Юнит тест за всеки следващ добавяме едно
        }
    }
}
