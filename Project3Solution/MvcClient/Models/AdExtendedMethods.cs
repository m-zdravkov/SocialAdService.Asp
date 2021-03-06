﻿using MvcClient.SasPublic;
using MvcClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClient.Models
{
    public static class AdExtendedMethods
    {
        public static AdWithCommentsViewModel[] AttachReplies(this Ad[] list,
            SocialAdServicePublicClient client = null)
        {
            if (client == null)
            {
                using (var newClient = ServiceHelper.GetPublicServiceClient())
                {
                    return AttachRepliesFromClient(list, newClient);
                }
            }
            else
            {
                return AttachRepliesFromClient(list, client);
            }
        }

        private static AdWithCommentsViewModel[] AttachRepliesFromClient(Ad[] list,
            SocialAdServicePublicClient client)
        {
            var awc = new AdWithCommentsViewModel[list.Length];
            
            for (int i = 0; i < list.Length; i++)
            {
                awc[i] = new AdWithCommentsViewModel
                {
                    Ad = list[i],
                    Comments = client.GetAdReplies(0, 64, list[i]?.Id),
                };
            }

            return awc;
        }
    }
}