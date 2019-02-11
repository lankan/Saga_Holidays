﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json; 

namespace Tests.Stubs
{
    public static class Basket_Stub
    {
       
       public static List<Basket> getBokingStubData()
       {
            string json = "[{\"transactionNumber\":\"0002b3be-4f0b-418a-b7dd-670494981a89\",\"numberOfPassengers\":null,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-08-08T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"0003af0c-24a5-4948-81e4-5f19abf2f565\",\"numberOfPassengers\":null,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-10-21T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"000840f3-e60c-4359-9ad5-b5de77c801c4\",\"numberOfPassengers\":null,\"domain\":10,\"agentId\":null,\"referrerUrl\":\"https://dev.titantravel.test/destinations/north-america/usa/california/california-and-the-golden-west\",\"createdDateTime\":\"2018-07-04T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"00122014-a7ff-4fff-8a91-9d676a5d5e4f\",\"numberOfPassengers\":null,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-10-24T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"001da34a-034e-40e4-8c9b-e66ca7b1dd6c\",\"numberOfPassengers\":null,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-11-04T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"001e0ada-0e08-4880-bbf6-ff84f1fe1075\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"http://uat9.cms.travel.saga.co.uk/Ocean-Cruises/Where-we-cruise/Canaries/Canary-Islands-and-Cape-Verde.aspx?availability=2&duration=1-999&boardbasis=FB\",\"createdDateTime\":\"2016-10-14T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"002b12ea-1f35-4ade-bb43-559888029ed8\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"http://uat9.cms.titan.dev/destinations/europe/portugal/madeira/madeira-carnival\",\"createdDateTime\":\"2016-11-09T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"}," + 
                          "{\"transactionNumber\":\"002c5ecd-396a-4b76-8eaf-59114ef8863b\",\"numberOfPassengers\":null,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-07-29T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"002d3eca-3bbf-4433-9417-53b8878a14c3\",\"numberOfPassengers\":null,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-08-05T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"002e7a2e-653d-424c-a3ed-c287fe3a1666\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"http://uat9.cms.travel.saga.co.uk/Ocean-Cruises/Where-we-cruise/British-Isles-and-Ireland/St-Patricks-Day-Getaway.aspx?boardbasis=AI\",\"createdDateTime\":\"2016-10-13T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"002f5a9f-b148-461c-a598-fc3f8ba5c4b6\",\"numberOfPassengers\":2,\"domain\":10,\"agentId\":null,\"referrerUrl\":\"https://uat4.titantravel.test/destinations/europe/italy/scenic-lake-orta-and-a-matterhorn-rail-journey?availability=2&boardbasis=HB\",\"createdDateTime\":\"2018-05-17T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"0031af50-7b96-46f1-9eaa-f6ec0dd8f46c\",\"numberOfPassengers\":null,\"domain\":10,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2017-01-20T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"0034184d-a991-486a-a7c5-7bc106857205\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-10-05T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"0035561c-40a8-4cfe-bfab-5bb3fbc130d8\",\"numberOfPassengers\":null,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-07-29T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"0035b294-36fa-4972-935e-81c546184e84\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-08-17T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"0037bd4c-abc6-49ec-a1fc-813f24c1b4cf\",\"numberOfPassengers\":1,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"http://uat9.cms.travel.saga.co.uk/Ocean-Cruises/Where-we-cruise/Norway-and-Scandinavia/Fjords-and-Fireworks.aspx?availability=1&duration=8-13&startdate=01/05/2017&enddate=31/05/2017&boardbasis=FB\",\"createdDateTime\":\"2016-10-14T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"0039b43e-11e3-4186-ada7-07036a6189bc\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"http://uat9.cms.travel.saga.co.uk/Destinations/Europe/Spain/Costa-Tropical/Hotel-Helios-Costa-Tropical.aspx?boardbasis=HB\",\"createdDateTime\":\"2016-10-28T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"003eb226-69ee-489a-904b-fa43500e6e9c\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"http://uat9.cms.travel.saga.co.uk/Destinations/Australasia/Australia/Ultimate-Australia.aspx?boardbasis=NONE\",\"createdDateTime\":\"2016-10-13T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"},{\"transactionNumber\":\"004004e4-3de9-4ebd-8336-4b6f42a66c33\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"http://uat9.cms.travel.saga.co.uk/Destinations/Asia/Sri-Lanka/Club-Palm-Bay-Hotel.aspx?availability=2&duration=1-999&boardbasis=AI\",\"createdDateTime\":\"2016-09-30T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"}," + 
                          "{\"transactionNumber\":\"0042ba14-e1eb-45e0-92e5-ac2c8cfdcc98\",\"numberOfPassengers\":2,\"domain\":1,\"agentId\":null,\"referrerUrl\":\"\",\"createdDateTime\":\"2016-09-22T00:00:00\",\"userId\":\"TestUser\",\"selectedCurrency\":\"GBP\",\"reservationSystem\":\"Taurus\"}]";

            return JsonConvert.DeserializeObject<List<Basket>>(json);
       }
    }
}
