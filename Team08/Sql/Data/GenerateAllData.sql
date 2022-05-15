-- Drop Data
-- DELETE FROM SpaceFlight.Person
-- DELETE FROM SpaceFlight.Flight
-- DELETE FROM SpaceFlight.Planet
-- DELETE FROM SpaceFlight.SolarSystem
-- DELETE FROM SpaceFlight.FlightPerson
-- DELETE FROM SpaceFlight.SpaceShip
-- DELETE FROM SpaceFlight.ShipType

-- View Tables
SELECT *
FROM SpaceFlight.Person
SELECT *
FROM SpaceFlight.Flight
SELECT *
FROM SpaceFlight.Planet 
SELECT *
FROM SpaceFlight.SolarSystem 
SELECT *
FROM SpaceFlight.FlightPerson 
SELECT *
FROM SpaceFlight.SpaceShip
SELECT *
FROM SpaceFlight.ShipType

-- SolarSystem Data
INSERT SpaceFlight.SolarSystem(SolarSystemName)
VALUES 
    (N'System456'),
    (N'System123'),
    (N'The Solar System')

-- Planet Data
INSERT SpaceFlight.Planet(SolarSystemID, PlanetName, Mass, Radius, XCoordinate, YCoordinate)
VALUES
    --    Solar        M     R     X     Y
    (2, N'WASP-148 b', 91.2, 8.47, 100, 10),
    (1, N'MASCARA-2 b/KELT-20 b', 0.934, 0.354, 583957, 563947),
    (1, N'Sand 178 b', 0.15, 0.10, 23456, -17593),
    (2, N'KELT-9 b', 29, 92, -1186, 26453),
    (2, N'EPIC 246851721 b', 1489, 1264, -9756, -4675),
    (2, N'TOI-1260 c', 86, 324, 3465596, -7855246),
    (1, N'61 Vir b', 642, 4758, -485, 9853),
    (2, N'GJ 433 b', 306, 479, 46587, 67583),
    (1, N'Kepler-1656 b', 47.8, 5.02, 1000, 28),
    (2, N'Proxima Centauri d', 100, 0, 10000, 1000),
    (1, N'K2-99 b', 277, 11.72, 246, -1003),
    (3, N'Mercury', 3.29, 1516.00, 2.585, -3.0),
    (3, N'Venus', 48.67, 3760.4, 8.4, 9.2),
    (3, N'Earth', 59.72, 3958.8, 0.0, 0.0),
    (3, N'Mars', 6.39, 2106.1, 1.7, 1.0),
    (3, N'Jupiter', 189.00, 43.441, 3.13, -14.8),
    (3, N'Saturn', 168.00, 36184.00, -2.9, -14.48),
    (3, N'Uranus', 68.1, 5759.00, 4.56, -5.23),
    (3, N'Neptune', 24.00, 1529.00, -3.3, 25.89);

-- Person Data
INSERT SpaceFlight.Person(FirstName, LastName, EmailAddress)
VALUES
    (N'Rosella', N'Meert', N'Rosella@gmail.com'),
    (N'Matthew', N'Graham', N'matty@ksu.edu'),
    (N'Albert', N'Smith', N'alSmith@yahoo.com'),
    (N'Tom', N'Cruz', N'cruzIsCrazy@gmail.com'),
    (N'Elon', N'Musk', N'elonMusk@tesla.com'),
    (N'Janet', N'Withers', N'withers@tesla.com'),
    (N'Caleb', N'Sanches', N'caleb@yahoo.com'),
    (N'Ben', N'Hur', N'hurHouse@gmail.com'),
    (N'Sadie', N'Smith', N'sadiesmith@ksu.edu'),
    (N'Jose', N'Delgato', N'joseD@byu.edu'),
    (N'Nicolas', N'Saint', N'northP@gmail.com'),
    (N'James', N'Madison', N'foundingFather@cia.gov'),
    (N'Madison', N'Jane', N'madijane@yahoo.com'),
    (N'Booker', N'T. Washington', N'bookerTaliferno@gmail.com'),
    (N'George', N'Knight', N'knights234@gmail.com'),
    (N'Jim', N'Graham', N'grahamcracker@ksu.edu'),
    (N'Jerry', N'Willson', N'mrwilson@gmail.com'),
    (N'Dennis', N'Menace', N'denn@yahoo.com'),
    (N'Cooper', N'Lawson', N'cooperlaw@ksu.edu'),
    (N'Sarah', N'Smith', N'sarahsmith@gmail.com'),
    (N'Ann', N'Whithers', N'ennann@studioc.com'),
    (N'Michael', N'Cain', N'shl@yahoo.com'),
    (N'Hardy', N'Har', N'hh@gmail.com'),
    (N'Lenny', N'Markish', N'markishlenny@gmail.com'),
    (N'Yashet', N'Narkish', N'yashnark@gmail.com'),
    (N'Kansas', N'Smith', N'kankan@gmail.com'),
    (N'John', N'Rock', N'johnrock@gmail.com'),
    (N'Jane', N'Rock', N'janerock@yahoo.com'),
    (N'Mark', N'Flec', N'mark@yahoo.com'),
    (N'Tom', N'Baker', N'bakertom@ksu.edu'),
    (N'Mal', N'Everton', N'ahyah@studioc.com'),
    (N'Peter', N'Parker', N'spidysence@mit.edu'),
    (N'Janetta', N'Bladon', N'Janetta@gmail.com'),
    (N'Peg',N'Buterton', N'PegButerton.com'),
    (N'Keeley',N'Lalevee', N'Keeleyalevee@gmail.com'),
    (N'Cullan',N'Maharry', N'CullanMaharry@gmail.com'),
    (N'Emanuele', N'Attwell', N'EmanueleAttwell@gmail.com'),
    (N'Chevalier',N' Dietsche', N'ChevalierDietsche@gmail.com'),
    (N'Aleece',N'Fitzpayn', N'AleeceFitzpayn@gmail.com'),
    (N'Brit',N' Davley', N'BritDavley@gmail.com'),
    (N'Claresta',N'Kinnear', N'ClarestaKinnear@gmail.com'),
    (N'Mike',N'Wazowski', N'mike@gmail.com'),
    (N'James',N'Sulivan', N'sulivanjp@gmail.com'),
    (N'Lois',N'Basin', N'loisbasin@gmail.com'),
    (N'Janet',N'Peppers', N'janetpepper@gmail.com'),
    (N'Dell',N'Glen', N'dellglen@gmail.com'),
    (N'Lucy',N'Pevincy', N'lucy@gmail.com'),
    (N'Larry',N'Coldwell', N'larrycoldwell@gmail.com'),
    (N'Peter',N'Stults', N'stultsandstuff@gmail.com'),
    (N'Mark',N'Hamilton', N'hamiltonconstruction@gmail.com'),
    (N'Carren',N'Whittle', N'whittling@gmail.com'),
    (N'Lauren',N'Baker', N'bakerbaking@gmail.com'),
    (N'James',N'Write', N'rightman@gmail.com');

-- Flight Data
INSERT SpaceFlight.Flight(ShipID, DeparturePlanetID, DestinationPlanetID, DepartureDateTime, ArrivalDateTime, TicketPrice)
VALUES
    (1, 14, 15, N'2027-01-01', NULL, 5000),
    (2, 14, 15, N'2027-01-01', NULL, 5000),
    (11, 14, 10, N'2027-01-01', NULL, 11500),
    (8, 14, 10, N'2027-01-01', NULL, 20650),
    (13, 14, 10, N'2027-01-01', NULL, 4100),
    (3, 14, 15, N'2028-01-01', NULL, 4500),
    (16, 14, 2, N'2028-01-01', NULL, 120000),
    (17, 14, 2, N'2028-05-01', NULL, 120000),
    (18, 14, 6, N'2028-01-01', NULL, 120000),
    (50, 14, 4, N'2029-01-01', NULL, 22000),
    (49, 14, 4, N'2029-05-01', NULL, 2200),
    (48, 14, 4, N'2029-06-01', NULL, 2200),
    (47, 14, 5, N'2029-07-01', NULL, 2200),
    (46, 14, 5, N'2029-08-01', NULL, 22000),
    (45, 14, 5, N'2029-09-01', NULL, 22000),
    (44, 14, 6, N'2029-01-01', NULL, 200),
    (43, 14, 6, N'2029-01-31', NULL, 2000),
    (42, 14, 7, N'2031-01-01', NULL, 22000),
    (41, 14, 7, N'2031-02-01', NULL, 200),
    (40, 14, 7, N'2031-01-01', NULL, 22000),
    (39, 14, 7, N'2031-09-01', NULL, 230),
    (38, 14, 9, N'2031-10-01', NULL, 22000),
    (37, 14, 8, N'2031-01-01', NULL, 21000),
    (8, 14, 15, N'2023-01-01', N'2024-03-01', 4200),
    (8, 14, 15, N'2025-01-01', N'2026-03-01', 2200),
    (12, 14, 15, N'2023-01-01', N'2024-02-01', 800),
    (12, 14, 15, N'2025-01-01', N'2026-02-01', 500),
    (9, 14, 10, N'2023-01-01', N'2026-02-01', 12000),
    (10, 14, 10, N'2023-01-01', N'2026-02-01', 12000),
    (15, 14, 19, N'2023-01-01', N'2024-05-01', 1100),
    (14, 14, 19, N'2024-01-01', N'2025-05-01', 1100),
    (35, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (34, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (33, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (31, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (32, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (31, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (30, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (29, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (28, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (27, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (26, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (25, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (24, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (23, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (22, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (21, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (20, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (19, 14, 15, N'2022-01-01', N'2023-01-01', 5000),
    (13, 14, 16, N'2023-01-01', N'2024-05-01', 200);


-- FlightPerson Data
INSERT SpaceFlight.FlightPerson(FlightID, PersonID)
VALUES 
    (50, 8),
    (50, 9),
    (33, 10),
    (31, 11);

    (48 , 25),
    (47 , 26),
    (46 , 27),
    (45 , 28),
    (44 , 29),
    (43 , 30),
    (42 , 1),
    (41 , 2),
    (40 , 3),
    (39 , 4),
    (38 , 7),
    (37 , 8),
    (37 , 9),
    (48 , 10),
    (47 , 11),
    (46 , 12),
    (45 , 13),
    (44 , 14),
    (43 , 15),
    (42 , 16),
    (41 , 17),
    (40 , 18),
    (39 , 19),
    (38 , 20),
    (37 , 21),
    (37 , 22),
    (1 , 25),
    (2 , 26),
    (3 , 27),
    (4 , 28),
    (5 , 29),
    (6 , 30),
    (7 , 1),
    (8 , 2),
    (9 ,3 ),
    (11 , 4),
    (12 , 7),
    (13 , 8),
    (14 , 9),
    (21 , 35),
    (22 , 36),
    (23 , 37),
    (24 , 38),
    (25 , 39),
    (26 , 40),
    (1,41),
    (1,42),
    (1,43),
    (1,44),
    (1,45),
    (1,46),
    (1,47),
    (1,48),
    (1,49);

-- SpaceShip Data
INSERT SpaceFlight.SpaceShip(ShipTypeID, ShipName)
VALUES
    (1, N'B0001'),
    (1, N'B0002'),
    (1, N'B0003'),
    (1, N'B0004'),
    (1, N'B0308'),
    (1, N'B0304'),
    (1, N'B0456'), 
    (1, N'B0345'),
    (1, N'B0234'),
    (1, N'B0023'),
    (1, N'B2194'),
    (1, N'B0368'),
    (1, N'B0307'),
    (1, N'B0426'),
    (1, N'B0011'),
    (1, N'B0012'),
    (1, N'B0013'),
    (1, N'B0014'),
    (1, N'B0021'),
    (1, N'B0022'),
    (1, N'B0029'),
    (1, N'B0024'),
    (2, N'P01'),
    (2, N'P02'),
    (2, N'P03'),
    (2, N'P04'),
    (2, N'P05'),
    (2, N'P06'),
    (2, N'P07'),
    (2, N'P08'),
    (2, N'P09'),
    (2, N'P10'),
    (2, N'P11'),
    (2, N'P12'),
    (2, N'P13'),
    (3, N'LRapter01'),
    (3, N'LRapter02'),
    (3, N'LRapter05'),
    (3, N'LRapter19'),
    (3, N'LRapter21'),
    (3, N'LRapter08'),
    (4, N'BF0010'),
    (4, N'BF0011'),
    (4, N'BF0012'),
    (4, N'BF0013'),
    (4, N'BF0020'),
    (4, N'BF0021'),
    (4, N'BF0022'),
    (4, N'BF0029'),
    (4, N'BF0030'),
    (4, N'BF0031'),
    (4, N'BF0032'),
    (4, N'BF0033'),
    (5, N'AB25'),
    (5, N'AB21'),
    (5, N'AB22'),
    (5, N'AB23'),
    (5, N'AB27'),
    (5, N'AB28'),
    (5, N'AB29'),
    (5, N'AB20'),
    (5, N'AB31'),
    (5, N'AB32');

INSERT SpaceFlight.ShipType([Name], Capacity)
VALUES
    (N'Boeing 747S', 800),
    (N'Piper Colony', 4000),
    (N'Lockheed RapterS', 20),
    (N'Boeing Freighter', 10),
    (N'Airbus Deep Transport', 1000);