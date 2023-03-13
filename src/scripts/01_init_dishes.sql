DROP TABLE IF EXISTS dishes;

CREATE TABLE categories(
    id UUID NOT NULL PRIMARY KEY,
    "name" VARCHAR(40)
);

INSERT INTO categories(id,"name") VALUES('63b48e2d-03df-4027-8ebc-b010beb57d6b', 'Drinks');
INSERT INTO categories(id,"name") VALUES('5871c8c7-6eb9-4569-9665-25a2889e37d0', 'Snacks');
INSERT INTO categories(id,"name") VALUES('6662389e-4dd9-4db9-9324-37be0c8c65fd', 'Lunch');

CREATE TABLE dishes(
    id UUID NOT NULL PRIMARY KEY,
    "name" VARCHAR(40),
    "description" VARCHAR(100),
    category UUID NOT NULL,
    FOREIGN KEY(category) REFERENCES categories(id)
);