CREATE DATABASE fleet_finder;
USE fleet_finder;

CREATE TABLE vehicle(
    vehicle_id INT AUTO_INCREMENT NOT NULL,
    numberPlate  VARCHAR(20) NOT NULL,
    `fuel_cost/km` DECIMAL NOT NULL,
    is_available BOOLEAN NOT NULL,

    PRIMARY KEY(vehicle_id)
);

CREATE TABLE hire(
    hire_id INT AUTO_INCREMENT,
    vehicle_id INT,
    customer_name VARCHAR(50) NOT NULL,
    customer_phone_number VARCHAR(9) NOT NULL,
    is_returned BOOLEAN NOT NULL,

    PRIMARY KEY(hire_id),
    FOREIGN KEY(vehicle_id) REFERENCES vehicle(vehicle_id)
    
);

CREATE TABLE trip(
    trip_id INT AUTO_INCREMENT,
    vehicle_id INT,
    route_name VARCHAR(50) NOT NULL,
    trip_No INT NOT NULL,
    trip_start_time TIME NOT NULL,
    has_arrived BOOLEAN NOT NULL,

    PRIMARY KEY(trip_id),
    FOREIGN KEY(vehicle_id) REFERENCES vehicle(vehicle_id)
    
);

CREATE TABLE employee(
    employee_id INT AUTO_INCREMENT,
    Employee_type VARCHAR(50) NOT NULL,
    Employee_phone_number VARCHAR(10) NOT NULL,
    Is_available BOOLEAN NOT NULL,

    PRIMARY KEY(employee_id)
);

CREATE TABLE trip_employee(
    trip_employee_id INT AUTO_INCREMENT,
    trip_id INT,
    employee_id INT,

    PRIMARY KEY(trip_employee_id),
    FOREIGN KEY(trip_id) REFERENCES trip(trip_id),
     FOREIGN KEY(employee_id) REFERENCES employee(employee_id)  
);