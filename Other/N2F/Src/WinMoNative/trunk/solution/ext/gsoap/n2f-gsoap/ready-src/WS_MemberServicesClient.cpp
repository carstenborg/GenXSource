/* WS_MemberServicesClient.cpp
   Generated by gSOAP 2.7.10 from .\wsdl-h\MemberServices.h
   Copyright(C) 2000-2008, Robert van Engelen, Genivia Inc. All Rights Reserved.
   This part of the software is released under one of the following licenses:
   GPL, the gSOAP public license, or Genivia's license for commercial use.
*/
#include "WS_MemberServicesH.h"

namespace WS_MemberServices {

SOAP_SOURCE_STAMP("@(#) WS_MemberServicesClient.cpp ver 2.7.10 2008-04-13 13:01:17 GMT")


SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices2__GetEncryptionKey(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__GetEncryptionKey *MemberServices__GetEncryptionKey, _MemberServices__GetEncryptionKeyResponse *MemberServices__GetEncryptionKeyResponse)
{	struct __MemberServices2__GetEncryptionKey soap_tmp___MemberServices2__GetEncryptionKey;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/GetEncryptionKey";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices2__GetEncryptionKey.MemberServices__GetEncryptionKey = MemberServices__GetEncryptionKey;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices2__GetEncryptionKey(soap, &soap_tmp___MemberServices2__GetEncryptionKey);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices2__GetEncryptionKey(soap, &soap_tmp___MemberServices2__GetEncryptionKey, "-MemberServices2:GetEncryptionKey", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices2__GetEncryptionKey(soap, &soap_tmp___MemberServices2__GetEncryptionKey, "-MemberServices2:GetEncryptionKey", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__GetEncryptionKeyResponse)
		return soap_closesock(soap);
	MemberServices__GetEncryptionKeyResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__GetEncryptionKeyResponse->soap_get(soap, "MemberServices:GetEncryptionKeyResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices2__GetMemberID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__GetMemberID *MemberServices__GetMemberID, _MemberServices__GetMemberIDResponse *MemberServices__GetMemberIDResponse)
{	struct __MemberServices2__GetMemberID soap_tmp___MemberServices2__GetMemberID;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/GetMemberID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices2__GetMemberID.MemberServices__GetMemberID = MemberServices__GetMemberID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices2__GetMemberID(soap, &soap_tmp___MemberServices2__GetMemberID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices2__GetMemberID(soap, &soap_tmp___MemberServices2__GetMemberID, "-MemberServices2:GetMemberID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices2__GetMemberID(soap, &soap_tmp___MemberServices2__GetMemberID, "-MemberServices2:GetMemberID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__GetMemberIDResponse)
		return soap_closesock(soap);
	MemberServices__GetMemberIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__GetMemberIDResponse->soap_get(soap, "MemberServices:GetMemberIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices2__GetTagID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__GetTagID *MemberServices__GetTagID, _MemberServices__GetTagIDResponse *MemberServices__GetTagIDResponse)
{	struct __MemberServices2__GetTagID soap_tmp___MemberServices2__GetTagID;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/GetTagID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices2__GetTagID.MemberServices__GetTagID = MemberServices__GetTagID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices2__GetTagID(soap, &soap_tmp___MemberServices2__GetTagID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices2__GetTagID(soap, &soap_tmp___MemberServices2__GetTagID, "-MemberServices2:GetTagID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices2__GetTagID(soap, &soap_tmp___MemberServices2__GetTagID, "-MemberServices2:GetTagID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__GetTagIDResponse)
		return soap_closesock(soap);
	MemberServices__GetTagIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__GetTagIDResponse->soap_get(soap, "MemberServices:GetTagIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices2__CheckUserExists(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__CheckUserExists *MemberServices__CheckUserExists, _MemberServices__CheckUserExistsResponse *MemberServices__CheckUserExistsResponse)
{	struct __MemberServices2__CheckUserExists soap_tmp___MemberServices2__CheckUserExists;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/CheckUserExists";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices2__CheckUserExists.MemberServices__CheckUserExists = MemberServices__CheckUserExists;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices2__CheckUserExists(soap, &soap_tmp___MemberServices2__CheckUserExists);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices2__CheckUserExists(soap, &soap_tmp___MemberServices2__CheckUserExists, "-MemberServices2:CheckUserExists", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices2__CheckUserExists(soap, &soap_tmp___MemberServices2__CheckUserExists, "-MemberServices2:CheckUserExists", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__CheckUserExistsResponse)
		return soap_closesock(soap);
	MemberServices__CheckUserExistsResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__CheckUserExistsResponse->soap_get(soap, "MemberServices:CheckUserExistsResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices3__GetEncryptionKey(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__GetEncryptionKey *MemberServices__GetEncryptionKey, _MemberServices__GetEncryptionKeyResponse *MemberServices__GetEncryptionKeyResponse)
{	struct __MemberServices3__GetEncryptionKey soap_tmp___MemberServices3__GetEncryptionKey;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/GetEncryptionKey";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices3__GetEncryptionKey.MemberServices__GetEncryptionKey = MemberServices__GetEncryptionKey;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices3__GetEncryptionKey(soap, &soap_tmp___MemberServices3__GetEncryptionKey);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices3__GetEncryptionKey(soap, &soap_tmp___MemberServices3__GetEncryptionKey, "-MemberServices3:GetEncryptionKey", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices3__GetEncryptionKey(soap, &soap_tmp___MemberServices3__GetEncryptionKey, "-MemberServices3:GetEncryptionKey", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__GetEncryptionKeyResponse)
		return soap_closesock(soap);
	MemberServices__GetEncryptionKeyResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__GetEncryptionKeyResponse->soap_get(soap, "MemberServices:GetEncryptionKeyResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices3__GetMemberID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__GetMemberID *MemberServices__GetMemberID, _MemberServices__GetMemberIDResponse *MemberServices__GetMemberIDResponse)
{	struct __MemberServices3__GetMemberID soap_tmp___MemberServices3__GetMemberID;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/GetMemberID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices3__GetMemberID.MemberServices__GetMemberID = MemberServices__GetMemberID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices3__GetMemberID(soap, &soap_tmp___MemberServices3__GetMemberID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices3__GetMemberID(soap, &soap_tmp___MemberServices3__GetMemberID, "-MemberServices3:GetMemberID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices3__GetMemberID(soap, &soap_tmp___MemberServices3__GetMemberID, "-MemberServices3:GetMemberID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__GetMemberIDResponse)
		return soap_closesock(soap);
	MemberServices__GetMemberIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__GetMemberIDResponse->soap_get(soap, "MemberServices:GetMemberIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices3__GetTagID(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__GetTagID *MemberServices__GetTagID, _MemberServices__GetTagIDResponse *MemberServices__GetTagIDResponse)
{	struct __MemberServices3__GetTagID soap_tmp___MemberServices3__GetTagID;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/GetTagID";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices3__GetTagID.MemberServices__GetTagID = MemberServices__GetTagID;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices3__GetTagID(soap, &soap_tmp___MemberServices3__GetTagID);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices3__GetTagID(soap, &soap_tmp___MemberServices3__GetTagID, "-MemberServices3:GetTagID", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices3__GetTagID(soap, &soap_tmp___MemberServices3__GetTagID, "-MemberServices3:GetTagID", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__GetTagIDResponse)
		return soap_closesock(soap);
	MemberServices__GetTagIDResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__GetTagIDResponse->soap_get(soap, "MemberServices:GetTagIDResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

SOAP_FMAC5 int SOAP_FMAC6 soap_call___MemberServices3__CheckUserExists(struct soap *soap, const char *soap_endpoint, const char *soap_action, _MemberServices__CheckUserExists *MemberServices__CheckUserExists, _MemberServices__CheckUserExistsResponse *MemberServices__CheckUserExistsResponse)
{	struct __MemberServices3__CheckUserExists soap_tmp___MemberServices3__CheckUserExists;
	if (!soap_endpoint)
		soap_endpoint = "http://next2friends.com:90/MemberServices.asmx";
	if (!soap_action)
		soap_action = "http://www.next2friends.com/CheckUserExists";
	soap->encodingStyle = NULL;
	soap_tmp___MemberServices3__CheckUserExists.MemberServices__CheckUserExists = MemberServices__CheckUserExists;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___MemberServices3__CheckUserExists(soap, &soap_tmp___MemberServices3__CheckUserExists);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___MemberServices3__CheckUserExists(soap, &soap_tmp___MemberServices3__CheckUserExists, "-MemberServices3:CheckUserExists", "")
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___MemberServices3__CheckUserExists(soap, &soap_tmp___MemberServices3__CheckUserExists, "-MemberServices3:CheckUserExists", "")
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!MemberServices__CheckUserExistsResponse)
		return soap_closesock(soap);
	MemberServices__CheckUserExistsResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	MemberServices__CheckUserExistsResponse->soap_get(soap, "MemberServices:CheckUserExistsResponse", "");
	if (soap->error)
	{	if (soap->error == SOAP_TAG_MISMATCH && soap->level == 2)
			return soap_recv_fault(soap);
		return soap_closesock(soap);
	}
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

} // namespace WS_MemberServices


/* End of WS_MemberServicesClient.cpp */