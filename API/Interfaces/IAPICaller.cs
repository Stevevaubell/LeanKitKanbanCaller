﻿using API.DTO;
using API.Entities;

namespace API.Interfaces
{
    public interface IApiCaller
    {
        IdentifierWrapper GetBoardIdentifiers(string boardId);
        AttributesWrapper GetBoardAttributes(string boardId);
        //string GetListOfItemsInBackLog(string boardId);
        //string GetListOfItemsInArchive(string boardId);
        //string GetListOfAllBoardsForAnAccount();
        //string AddCard(string boardId, string laneId, CardItem card);
        //string MoveCard(string boardId, string cardId, string laneId);
        //string UpdateCard(string boardId, string laneId, CardItem card);
    }
}
