﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using WebChat.Common;
//using WebChat.Data;

//namespace WebChat.Logic
//{
//    public class ChatManager_CallCenter_Rep
//    {

//        public static void TryTo_JoinChatRoom(Guid chatRoomID, HttpContextBase context, string alias)
//        {
//              Int32 sessionUID = -1;
//            tblChatRoom chatRoom = ChatRoomDAC.GetChatRoom(chatRoomID);

//            if (chatRoom == null)
//            {
//                throw new Exception("El chat expiró o no se encuentra abilitado");
//            }

//             //Si la session no existe la crea
//            if (SessionDAC.SessionExist(context.Session.SessionID) == false)
//            {
//                sessionUID = SessionDAC.CreateSession(context, alias);
//            }
//            else
//            {
//                //Obtener la session
//                var session = SessionDAC.GetSession(context.Session.SessionID);
//                sessionUID = session.UID;
//            }

//            //SessionFullview sessionFV = SessionDAC.GetSessionAlias(context.Session.SessionID, string.Empty, chatRoomID);

          
//                if (chatRoom.Status.Equals(Enumerations.ChatRoomStatus.ClosedByOwner))
//                {
//                    throw new Exception("El chat fue cerrado");
//                }

//                if (chatRoom.Status.Equals(Enumerations.ChatRoomStatus.ExpiredTimeout))
//                {
//                    throw new Exception("El chat expiró");
//                }
            

//            JoinChatRoom(chatRoomID, context, alias);
//        }

//        static void JoinChatRoom(Guid chatRoomID, HttpContextBase context, string alias)
//        {
//            //TODO: Ver esto
//            int sessionUID = 0;
//            //Si Talcker tiene CheckOutTime null no crea nada
//            //De lo contrario lo crea para ese chatroom particular
//            if (TalkersDAC.CheckTimeOut(sessionUID, chatRoomID))
//            {
//                return;
//            }
//            else
//            {
//                var room = ChatRoomDAC.GetChatRoom(chatRoomID);
//                #region Set talker
//                tblTalker talker = new tblTalker();
//                talker.ChatRoomID = chatRoomID;
//                talker.CheckInTime = DateTime.Now;
//                talker.CheckOutTime = null;
//                talker.SessionID = sessionUID;
//                //Es talker dueño si las session del chatroom = context.Session
//                talker.IsOwner = room.CreateOnSessionId.Equals(context.Session.SessionID);
//                #endregion
//                //Si el q se une no es cliente (owner del chatroom) verifiuca el estado enespera para pasarlo a active
//                if (!talker.IsOwner)
//                {
//                    if (room.Status.Equals((int)Enumerations.ChatRoomStatus.Waiting))
//                        ChatRoomDAC.Update_Chatroom(chatRoomID, (int)Enumerations.ChatRoomStatus.Active, null);
//                }
//                TalkersDAC.Create(talker);

//                return;
//            }
//        }
//        /// <summary>
//        /// Crea un chat room soli si no existe o el que existe no expiro
//        /// Incluye Join chat room
//        /// </summary>
//        /// <param name="roomName"></param>
//        /// <param name="creatorName"></param>
//        /// <param name="maxUserNumber"></param>
//        /// <param name="department"></param>
//        /// <param name="createOnSessionId"></param>
//        /// <param name="createdByUserName"></param>
//        /// <returns></returns>
//        public static ChatRoom TryCreateChatRoom(
//            string roomName, string creatorName,
//             int maxUserNumber, string department, 
//            HttpContextBase context)
//        {
//            Int32 sessionId = -1;
//            //Si la session no existe la crea
//            if (SessionDAC.SessionExist(context.Session.SessionID) == false)
//            {
//                sessionId = SessionDAC.CreateSession(context, creatorName);
//            }
//            else
//            {
//                //Obtener la session
//                var session = SessionDAC.GetSession(context.Session.SessionID);
//                sessionId = session.UID;
//            }
//            //El  cliente solo puede usar un chatroom por session
//            ChatRoom wChatRoom = SessionDAC.RetriveFirstChatroom(sessionId);
//            if (wChatRoom == null)
//            {
//                Guid chatRoomId = ChatRoomDAC.CreateChatRoom(roomName, creatorName, maxUserNumber, department, sessionId, "Gues Web Client ");

//                wChatRoom = new ChatRoom(chatRoomId,sessionId);
               
//            }

//            if (wChatRoom.Status.Equals(Enumerations.ChatRoomStatus.ClosedByOwner) 
//                || wChatRoom.Status.Equals(Enumerations.ChatRoomStatus.ClosedByOperator))
//            {
//                throw new Exception("El chat fue cerrado");
//            }

//            if (wChatRoom.Status.Equals(Enumerations.ChatRoomStatus.ExpiredTimeout))
//            {
//                throw new Exception("El chat expiró");
//            }
//            JoinChatRoom(wChatRoom);

//            return wChatRoom;
//        }


//        /// <summary>
//        /// 1-Create Talcker and set to chatroom
//        /// 
//        /// </summary>
//        /// <param name="chatRoomID"></param>
//        /// <param name="context"></param>
//        /// <param name="alias"></param>
//        /// <returns></returns>
//        static void JoinChatRoom(ChatRoom pChatRoom)
//        {

//            //Si Talcker tiene CheckOutTime null no crea nada
//            //De lo contrario lo crea para ese chatroom particular
//            //if (TalkersDAC.CheckTimeOut(pChatRoom.CreatedOnSessionId, pChatRoom.RoomID))
//            //{
//            //    return -1;
//            //}
//            //else
//            //{
      

//                #region Set talker
//                tblTalker talker = new tblTalker();
//                talker.ChatRoomID = pChatRoom.RoomID;
//                talker.CheckInTime = DateTime.Now;
//                talker.CheckOutTime = null;
//                talker.SessionID = pChatRoom.CreatedOnSessionId;
//                talker.IsOwner = true;
//                #endregion
                
//                 TalkersDAC.Create(talker);
//                pChatRoom.TalkerOwnerId = talker.TalkerID;
//            //}
//        }


//    }
//}