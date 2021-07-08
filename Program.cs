use Consumer

Create table [User]
(
	id int primary key identity(1,1),
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email nvarchar(50) not null unique,
	Age int
)

Create table[UserAddress] 
(
	id int primary key identity(1,1),
	UserId int references[User] (id) ,
	CountryCode nvarchar(50) not null,
	[State] nvarchar(50) not null unique,
	City nvarchar(50),
	[Address] nvarchar(50),
	PhoneNumber nvarchar(50) unique
)

Create table Discount
(
	id int primary key,
	[Value] int
)

Create table Cart
(
	id int primary key identity(1,1),
	UserId int unique references [User] (id),
	DiscountId int references[Discount] (id) 
)

Create table Category
(
	id int primary key,
	[Name] nvarchar(50)
)

Create table Product
(
	id int primary key,
	CategoryId int references [Category] (id),
	[Name] nvarchar(50),
	Price int
)

Create table CartItem
(
	CartId int references [Cart] (id),
	ProductID int references[Product] (id),
	[Count] int
)