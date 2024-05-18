-- Active: 1715991703299@@bcp4np8qhkbnv1amscku-mysql.services.clever-cloud.com@3306
CREATE TABLE Companie(
    Id int not null auto_increment,
    Name varchar(125),
    Address varchar(250),
    Phone varchar(25),
    Nit varchar(25),
    Logo varchar(250),
    PRIMARY KEY(Id)
);

/*insertamos datos*/
INSERT INTO Companie (Name, Address, Phone, Nit) VALUES
('Tech Solutions', '123 Main St, Springfield, IL', '555-1234', '1234567890'),
('Global Ventures', '456 Elm St, Metropolis, NY', '555-5678', '0987654321'),
('Innovative Designs', '789 Oak St, Gotham, NJ', '555-8765', '1122334455'),
('Eco Friendly Goods', '101 Pine St, Smallville, KS', '555-4321', '2233445566'),
('Healthcare Plus', '202 Birch St, Star City, CA', '555-6789', '3344556677');


DROP TABLE Companie;