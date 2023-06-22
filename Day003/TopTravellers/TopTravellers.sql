CREATE TABLE users(
    id NUMBER PRIMARY KEY,
    name VARCHAR2(50)
);

CREATE TABLE rides(
    id NUMBER PRIMARY KEY,
    userId NUMBER,
    distance NUMBER,
    FOREIGN KEY(userId) REFERENCES users(id)
);

INSERT INTO users VALUES(1,"Alice");
INSERT INTO users VALUES(2,"Bob");
INSERT INTO users VALUES(3,"Alex");
INSERT INTO users VALUES(4,"Donald");
INSERT INTO users VALUES(7,"Lee");
INSERT INTO users VALUES(13,"Jonathan");
INSERT INTO users VALUES(19,"Elvis");

INSERT INTO rides VALUES(1,1,120);
INSERT INTO rides VALUES(2,2,317);
INSERT INTO rides VALUES(3,3,222);
INSERT INTO rides VALUES(4,7,100);
INSERT INTO rides VALUES(5,13,312);
INSERT INTO rides VALUES(6,19,50);
INSERT INTO rides VALUES(7,7,120);
INSERT INTO rides VALUES(8,19,400);
INSERT INTO rides VALUES(9,7,230);

SELECT name,COALESCE((
    SELECT SUM(distance)
    FROM rides R
    WHERE R.userId = U.id
),0) AS travelled_distance
FROM users U
ORDER BY travelled_distance DESC,name ASC

