CREATE TABLE stocks(
    stock_name VARCHAR(50),
    operation ENUM('Sell','Buy'),
    operation_day INT,
    price INT,
    PRIMARY KEY (stock_name,operation_day)
);

INSERT INTO stocks VALUES('Leetcode','Buy',1,1000);
INSERT INTO stocks VALUES('Corona Masks','Buy',2,10);
INSERT INTO stocks VALUES('Leetcode','Sell',5,9000);
INSERT INTO stocks VALUES('Handbags','Buy',17,30000);
INSERT INTO stocks VALUES('Corona Masks','Sell',3,1010);
INSERT INTO stocks VALUES('Corona Masks','Buy',4,1000);
INSERT INTO stocks VALUES('Corona Masks','Sell',5,500);
INSERT INTO stocks VALUES('Corona Masks','Buy',6,1000);
INSERT INTO stocks VALUES('Handbags','Sell',29,7000);
INSERT INTO stocks VALUES('Corona Masks','Sell',10,10000);


SELECT stock_name,SUM(CASE WHEN operation = 'Buy' THEN -price WHEN operation = 'Sell' THEN +price ELSE 0 END) AS capital_gain_loss
FROM stocks
GROUP BY stock_name
ORDER BY capital_gain_loss DESC;