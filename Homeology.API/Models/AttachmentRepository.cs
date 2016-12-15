using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homeology.API.Models
{
    public class AttachmentRepository
    {
        private static HomeologyEntities homeologyContext = new HomeologyEntities();
        public static List<Attachment> GetAllAAttachments()
        {
            var query = from attachment in homeologyContext.Attachments
                        select attachment;
            return query.ToList();
        }

        public static List<Attachment> SearchAttachmentsByCaption(string attachentCaption)
        {
            var query = from attachment in homeologyContext.Attachments
                        where attachment.caption.Contains(attachentCaption)
                        select attachment;
            return query.ToList();
        }

        public static List<Attachment> SearchAttachmentsByCliendId(int clientId)
        {
            var query = from attachment in homeologyContext.Attachments
                        where attachment.client_id.Equals(clientId)
                        select attachment;
            return query.ToList();
        }

        public static List<Attachment> SearchAttachmentssByDeal(int dealId)
        {
            var query = from attachment in homeologyContext.Attachments
                        where attachment.deal_id.Equals(dealId)
                        select attachment;
            return query.ToList();
        }

        public static Attachment GetAttachment(int attachmentId)
        {
            var query = from attachment in homeologyContext.Attachments
                        where attachment.attachment_id == attachmentId
                        select attachment;
            return query.SingleOrDefault();
        }

        public static List<Attachment> InsertAttachment(Attachment e)
        {
            homeologyContext.Attachments.Add(e);
            homeologyContext.SaveChanges();
            return GetAllAAttachments();
        }

        public static List<Attachment> UpdateAttachment(Attachment e)
        {
            var data = (from attachment in homeologyContext.Attachments
                        where attachment.attachment_id == e.attachment_id
                        select attachment).SingleOrDefault();
            data.caption = e.caption;
            data.Client = e.Client;
            data.attachment1 = e.attachment1;
            homeologyContext.SaveChanges();
            return GetAllAAttachments();
        }

        public static List<Attachment> DeleteAttachments(Attachment e)
        {
            var data = (from attachment in homeologyContext.Attachments
                        where attachment.attachment_id == e.attachment_id
                        select attachment).SingleOrDefault();
            homeologyContext.Attachments.Remove(data);
            homeologyContext.SaveChanges();
            return GetAllAAttachments();
        }

    }
}