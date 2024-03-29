# MyMvcApp100


.NET Framework		Year				Visual Studio

1.0			2001				2001
1.x			2003				2003
2.0			2005				2005
3.0			2006				----
3.5			2008				2008
4.0			2010				2010
4.5			2012				2012
4.5.1			2013				2013
...

--------------------------LTS
4.7							2019
4.8 [ASP.NET MVC 5 - Web applications and Web APIs, ../]2022

.NET Core
1.0			2015				2015
1.0, 3.x, 5.0, 6.0, 7.0, 8.0

C# Language - C# 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0

What is Solution in .NET?
It is a collection of projects


Introduction to Object Oriented Programming - 

4-Major Pillars - 
	1) Abstraction - 
	2) Encapsulation
		Class as a container/template [Properties, Methods and Events]
			[Private, Protected, Public, Internal, Protected Internal]
		Types of classes- 
			Abstract, Concret, Inner, Sealed [Final], Static, Partial, Anonymous
	3) Inheritance - Reusability
			Generalization-To-Specialization
			Relationship - [IS-A] [HAS-A]
			Types - 
				Single, Multilevel, Multiple [Not Supported], Heirachy, Hybrid
	4) Polymorphism
		Compiletime, Static, Early Binding, Overloading
		Runtime, Dynamic, Late Binding, Overriding

abstract class Person{
	public Person(int sid){
		SocialId=sid;
	}
	SocialId;
}

class Customer : Person{
	public Customer(){

	}
	private int A; [Only within the class]
	protected int B; [As an inherited member]
	public int C; [As an instance member or as an inherited member]
	double COGS;
	
}

new Customer();

interface IBiology{
	biologyCalci();
}
interface IChemistry{
	chemistryCalci();
}
interface IPhysics{
	physicsCalci();
}
interface IScience:IBiology, IPhysics, IChemistry{
	
}

Customer obj=new Customer();
obj.C

class Science : IScience{
	physicsCalci();
	chemistryCalci();
	biologyCalci();
}

IBiology bioHod=new Science();
IChemistry chemHod=new Science();
IPhysics phyHod=new Science();
IScience director=new Science();

S.O.L.I.D. Principles

S - Single Responsibility Principle
O - Open Close Principle
L - Liskvo Substitution Principle
I - Interface Segregation Principle
D - Dependency Inversion Principle

Example of Inheritance - 

class Object{

}

class A:Object{
	private x;
	protected y;
	public z;
}

//class B:Ione, ITwo, IThree, A{


//IS-A
class B:A{
	public E;
}

Inherited Members [Public and Protected]
class C:B{
	public D;
}

Instance Members

C obj=new C();
obj.public members

class BasicMath{
	int addition(int i, int j)
	int addition(int i, int j, int k)
	int addition(double i, int j)
}
class AdvanceMath : BasicMath{
	int addition(double i, double j)
}


//Runtime Polymorphism

class Math{
	public virtual int addition(int i, int j){
		return i + j;
	}
}


class AdvanceMath : Math{
	public override int addition(int i, int j){
		return i + j + 1000;
	}	
}

Math obj=new Math();
obj.addition(1000,2000); //3000

AdvanceMath obj=new AdvanceMath();
obj.addition(1000,2000); //4000

Math obj=new AdvanceMath();
obj.addition(1000,2000); //4000


//Shadowing

class Math{
	public int addition(int i, int j){
		return i + j;
	}
}


class AdvanceMath : Math{
	public new int addition(int i, int j){
		return i + j + 1000;
	}	
}

Math obj=new Math();
obj.addition(1000,2000); //3000

AdvanceMath obj=new AdvanceMath();
obj.addition(1000,2000); //4000

Math obj=new AdvanceMath();
obj.addition(1000,2000); //3000

Example - InterviewApp

Function parameters - 
	input - Default
	out
	ref
	params
	
Purchase Order System
	Category, Product, Supplier, Shipper, Order, OrderDetail, Customer, Employee, Invoice
Namespace [In Java it is Package]- 

Constructors - Initialization
1) Default
2) Parmeterized
3) Copy
4) Static

class Customer{
	static int i=0;
	public Customer(){
		++i;
	}
}

new Customer();
new Customer();
new Customer();

Data Storage - 

In-Memory - 
	Array
	Collections
		1) Non-Generic Collections [Boxing and Unboxing]
			[import a namespace - System.Collections]
			ArrayList, Stack, Queue, Hashtable
		Boxing - Convert Value Type into Reference Type
		Unboxing - Convert Reference Type into Value Type

		2) Generics Collections [C# 2.0]
			[import - System.Collections.Generic]
			List<T>, Stack<T>, Queue<T>, Dictionary<TKey,TValue>

File System [System.IO]
	File [Offers number of static methods]
	DriveInfo [Information of drives]
	DirectoryInfo
	FileInfo
	StreamWriter
	StreamReader
	FileStream
	...

Database - ADO.NET 
	Connection String - 
		Data Source/Server = It is a name of your Database Server [It is an IP address/machine name along with PORT number in MySQL Server]
	PORT
	Database Name
	User Id
	Password

	"Data Source=192.168.100.80;Port=3306;Database=PODb;User Id=saleel;Password=saleel"
		
Download the provider of MySQL Server in order to connect and perform the CRUD operations in MySQL Server database
	It's a DDL [API/Library]
		MySql.Data.dll
ADO.NET Architecture - 
	1) Disconnected Architecture
		MySqlConnection [MySql.Data.MySqlClient]
		MySqlDataAdapter - It takes connection object and queries. Go to the database server [MySql.Data.MySqlClient]
		DataSet [Internally it has Xml structure] [System.Data;]
			It is a collection of data tables
			Each table can be accessed  using either an index number or the table name
			Each Data table is a collection of Data Row and Data Column
	2) Connected Architecture
		MySqlConnection [MySql.Data.MySqlClient]
			You have to open and close the connection explicitly
		MySqlCommand [MySql.Data.MySqlClient]
			ExecuteReader() = MySqlDataReader 
			[All Select queries which returns multiple cols and rows]
			[MySqlDataReader implements ForwardOnly Cursor]

			ExecuteNonQuery() = Int
			[Use this method to perform Insert/Update/Delete operations]
			ExecuteScalar()
			[All Select queries which returns single col and single row output - Agreegate Queries - sum, min, max, count, avg, ...]
			
		MySqlCommand object can be used for executing simple queries as well as Stored Procedures
			It gives you one property - CommandType
				1) Text/Default [Simple SQL Queries]
				2) StoredProcedure
				3) TableDirect [Table Name]
			It gives you one property - CommandText
				Queries/Stored Procedure names
			Parameters - Parameters to your query or to your stored procedure

To read App.config or Web.config, you need a DLL reference - System.Configuration;
	This DLL will give you one class. ConfigurationManager which will help  to read the setting of an application which you have added in App.config/Web.config

Examples - 
	ArrayList numbers=new ArrayList(5);
	numbers.Add(100); //Object //Boxing
	numbers.Add("Two Hundred"); //Object
	int firstNo=Convert.ToInt32(numbers[0]);//Return an object //Error
		//Unboxing

Boxing and Unboxing


Generic Collections - Does not do boxing and Unboxing
List<int> numbers=new List<int>();
numbers.Add(100);
numbers.Add("Two Hundred"); //It will throw you an error Reason - Type Missmatch
int firstNo=numbers[0];

Threading - [System.Threading]
	i) CPU Bound Operations	[Main Thread]
		L1, L2 and L3 cache
		RAM
	ii) IO Bound Operations [Threading]
		Disk Operations
		Network Operations

	1) Native Thread - Operating System
	2) Green Thread - These threads are created by Runtime or Virtual Machine

In .NET Framework, threads are managed by CLR and called as Green Threads
	1) Create a new thread
	2) Set Priority
	3) Suspend/Abort the thread
	4) Wait until the other threads are not finished with their jobs

Thread Synchronization
	1) Lock
	2) Monitor
	3) Mutex
	4) Semaphore

LINQ - Language Integrated Query
	1) OLINQ - Linq-To-Object
	2) XLINQ - Linq-To-Xml
	3) DLINQ - Linq-To-Data

SQL - 

Select */col1, col2,.. from table
where condition
group by clause
order by expression;


from variable_name in Collection
select variable_name;

from variable_name in Collection
where variable_name.property==value
select variable_name;


from variable_name in Collection
orderby variable_name.property descending
select variable_name;

Linq-To-Xml - System.Xml.Linq

	XElement
	XAttribute

<Customers> - Element and Arrtibute
	<Customer customerId="1200" contactName="Pravinkumar R. D." city="Pune">
		<Orders>
			<Order orderId="123" qty="10"/>
		</Orders>
	</Customer>
</Customers>

Proof-Of-Concept - Project
	Events Management Portal [Roles - Employee and Hr]
		Employee - 
			1) Register his/her profile
			2) Employee can see other employees and details of a specific employee
			3) Employee can register to a specific event
			4) Employee can give the feedback of an event
		Hr
			All resposibliites of Employee
			1) Scheduling the events
			2) Canceling/Postponing events
			3) Collecting the feedback

Web application [Model-View-Controller]
ASP.NET MVC 5.x along with CSS Bootstrap 5.x framework

What is a Web Application/WebSite?
Collection of Resources
	Web pages [Html, CSS and JavaScript] [Static and Dynamic]
	Images
	Configuration [Web.config]
	Data - [ADO.NET/Entity Framework (O/RM)]
	Logic [Models - Data and Logic]
	CSS [Styling]
	JavaScript [Validations and AJAX calls]
	...

ASP.NET MVC - Architectural Pattern [Server Side]
	M - Model [Data and Logic]
	V - View [Display - View Engine - Razor - Generate Html on server side] [Extension of View file will be .cshtml]
	C - Controller [Accept the request and send the response - Main]
		Controller is a collection Action methods. Action methods are the ultimate destination of your request
		In general - Controller is a class which contains number of methods and these methods are called as action methods
		3-Types of action methods
			Default [Index], Named, Parmeterized

Routing - 
	https://localhost:2378/{Controller}/{ActionMethod}/{id?-Parameter}
	https://localhost:2378/Home[Default]/Index[Default]	

	https://localhost:2378 [Default Route]

	https://localhost:2378/Employees [Named/Specific Route]
	https://localhost:2378/Employees/List [Named/Specific Route]
	https://localhost:2378/Employees/New [Named/Specific Route]
	https://localhost:2378/Employees/Modify [Named/Specific Route]
	https://localhost:2378/Employees/Details/1029 [Parameterized/Dynamic Route]

	https://localhost:2378/Events/List [Named/Specific Route]
	https://localhost:2378/Events/New [Named/Specific Route]
	https://localhost:2378/Events/Modify [Named/Specific Route]
	https://localhost:2378/Events/Details/1000 [Dynamic Route]


1) Create ASP.NET MVC application with the name - 
	Synechron.EventsPortal
2) Configure Bootstrap CSS 5.x framework along with United/Pulse

3) Create Tables and Stored Procedures [Table Names are Plural]
	1) Employees
		[EmployeeId (AutoGeneration), EmployeeName, Address, City, Country, Phone, Email, Skillsets, Avatar, Zipcode]
	2) Events [EventId, EventCode, EventName, Description, StartDate, EndDate, Fees, TotalSeatsFilled, Logo]
	3) Users
		[UserId, Email, Password, RoleName]

4) Create Models according to the Table structure [Model names are singular]. Models must be created in Models folder

5) Create/Add Controllers with the name 
	Employees
	Events
	Security



Communication between View and Controller - 
	How to pass extra data other than model to the view?
	1) ViewBag - ViewBag is a Dynamic object [Available In the same request]
	2) ViewData - You store the values in Dictionary Format and explicit typecasting is required [Available In the same request]
	3) TempData
	4) ViewModel

dabade.pravinkumar@gmail.com
+91 9665622460






Models - Contain Data and Logic of your application

How do you add validations and where can we use these validations?
	1) Client Side using JavaScript
	2) Server Side Validations [In case, JavaScript is disabled on client browser]

	Use Data Annotations [System.ComponentModel.DataAnnotations]
	[Attribute]

ASP.NET MVC Razor offers number of Html helper methods which will get processed on server and will generate an appropriate Html


Assignment - 
	1) Display the list of Events and EventDetails as Master-Details
		List of Events [EventCode, EventName, Start Date and Fees with Show Details button]
	2) Insert New Event
	3) Configure Navbar with ActionLink Html helper methods

ASP.NET MVC Scaffolding Engine

Anytime you perform Insert, Update and Delete Requests - 
	Http GET and Http Post

















