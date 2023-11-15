/*CREATE TABLE "favoriteComponents"(
    "componentID" BIGINT NOT NULL,
    "uid" BIGINT NOT NULL,
    "favored" CHAR(1) NOT NULL
);
ALTER TABLE
    "favoriteComponents" ADD PRIMARY KEY("componentID");
CREATE TABLE "makesUp"(
    "flightID" BIGINT NOT NULL,
    "drinkID" BIGINT NOT NULL
);
ALTER TABLE
    "makesUp" ADD PRIMARY KEY("flightID", "drinkID");

CREATE TABLE "drink"(
    "drinkID" BIGINT NOT NULL,
    "drinkName" VARCHAR(255) NOT NULL,
    "alcName" VARCHAR(255) NOT NULL,
    "alcVol" DECIMAL(8, 2) NOT NULL,
    "ingredientID" BIGINT NOT NULL,
    "alcID" BIGINT NOT NULL
);
ALTER TABLE
    "drink" ADD PRIMARY KEY("drinkID");
CREATE TABLE "drinkHistory"(
    "flightID" BIGINT NOT NULL,
    "uid" BIGINT NULL,
    "flightName" VARCHAR(255) NOT NULL,
    "numberOfDrinks" BIGINT NOT NULL,
    "dateCreated" DATE NOT NULL
);
ALTER TABLE
    "drinkHistory" ADD PRIMARY KEY("flightID");
CREATE TABLE "userAccounts"(
    "uid" BIGINT NOT NULL,
    "password" VARCHAR(255) NOT NULL,
    "userEmail" VARCHAR(255) NOT NULL,
    "username" VARCHAR(255) NOT NULL,
    "userBirthDate" DATE NOT NULL
);
ALTER TABLE
    "userAccounts" ADD PRIMARY KEY("uid");
ALTER TABLE
    "makesUp" ADD CONSTRAINT "makesup_flightid_foreign" FOREIGN KEY("flightID") REFERENCES "drinkHistory"("flightID");
ALTER TABLE
    "drinkHistory" ADD CONSTRAINT "drinkhistory_uid_foreign" FOREIGN KEY("uid") REFERENCES "userAccounts"("uid");
ALTER TABLE
    "makesUp" ADD CONSTRAINT "makesup_drinkid_foreign" FOREIGN KEY("drinkID") REFERENCES "drink"("drinkID");
ALTER TABLE
    "favoriteComponents" ADD CONSTRAINT "favoritecomponents_uid_foreign" FOREIGN KEY("uid") REFERENCES "userAccounts"("uid");
    */